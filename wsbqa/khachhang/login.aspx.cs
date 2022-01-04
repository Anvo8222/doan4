using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.khachhang
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            string con = Session["con"].ToString();
            SqlConnection conn = new SqlConnection(con);
            captcha1.ValidateCaptcha(Capcha.Text.Trim());
            Button dangnhap = (Button)sender;
            string tendangnhap = txtEmail.Text;
            string matkhau = txtPassword1.Text;
            string pass = wsbqa.MD5.ToMD5(matkhau);
            string sql1 = "select * from TAIKHOAN where EMAIL = '" + tendangnhap + "' and MATKHAU = '" + matkhau + "' and IDPHANQUYEN=1";
            string sql2 = "select * from TAIKHOAN where EMAIL = '" + tendangnhap + "' and MATKHAU = '" + pass + "' and IDPHANQUYEN=2 and TRANGTHAI=N'đã kích hoạt'";
            string sql3 = "select * from TAIKHOAN where EMAIL = '" + tendangnhap + "' and MATKHAU = '" + pass + "' and IDPHANQUYEN=3 and TRANGTHAI=N'đã kích hoạt'";
            //bảng admin
            DataTable table1 = new DataTable();
            //KHÁCH HÀNG
            DataTable table2 = new DataTable();
            //THÀNH VIÊN
            DataTable table3 = new DataTable();
            try
            {
                //ADMIN
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
                //KHACH HANG
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
                //THANH VIEN
                SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn);
                da1.Fill(table1);
                da2.Fill(table2);
                da3.Fill(table3);

            }
            catch (SqlException err)
            {
                Response.Write("<p><b>Error: </b>" + err.Message + "</p>");
            }
            if (table1.Rows.Count != 0 && table2.Rows.Count == 0 && table3.Rows.Count == 0 && captcha1.UserValidated)
            {
                //admin

                Session["Tendangnhap"] = tendangnhap;
                Session["kiemtradangnhap"] = "1";
                Session["MADANGNHAP"] = table1.Rows[0].Field<Int32>("IDUSER").ToString();
                Response.Redirect("./index.aspx");


            }
            else if (table1.Rows.Count == 0 && table2.Rows.Count != 0 && table3.Rows.Count == 0 && captcha1.UserValidated)
            {
                //KHACH HANG
                Session["Tendangnhap"] = tendangnhap;
                Session["kiemtradangnhap"] = "2";
                Session["MADANGNHAP"] = table2.Rows[0].Field<Int32>("IDUSER").ToString();
                Response.Redirect("./index.aspx");

            }
            else if (table1.Rows.Count == 0 && table2.Rows.Count == 0 && table3.Rows.Count != 0 && captcha1.UserValidated)
            {
                //THANH VIEN
                Session["Tendangnhap"] = tendangnhap;
                Session["kiemtradangnhap"] = "3";
                Session["MADANGNHAP"] = table3.Rows[0].Field<Int32>("IDUSER").ToString();
                Response.Redirect("./index.aspx");

            }
            else if (table1.Rows.Count == 0 && table2.Rows.Count == 0 && table3.Rows.Count == 0)
            {
                Response.Write("<script>alert('Email hoặc mật khẩu không chính xác');</script>");
            }
            else
            {
                Label1.Text = "Sai mã capcha!";
            }
        }
    }
}