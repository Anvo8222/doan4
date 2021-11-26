using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace wsbqa.khachhang
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String maSanPham = Session["masanpham"].ToString();
                string query;
                query = "select *from SANPHAM,TAIKHOAN,DANHMUCSANPHAM where IDSANPHAM='" + maSanPham + "' AND SANPHAM.IDUSER=TAIKHOAN.IDUSER AND SANPHAM.IDDANHMUC=DANHMUCSANPHAM.IDDANHMUC ";
                DataTable dt = kn.laydata(query);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                Repeater2.DataSource = dt;
                Repeater2.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);

            }
        }

        protected void btnMuaNgay_Click(object sender, EventArgs e)
        {
            //mua ngay
        }
        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //link button
            //them vao gio
            //them vao gio hang
            LinkButton themvaogio = (LinkButton)sender;
            string idsanpham = themvaogio.CommandArgument.ToString();
            RepeaterItem item = (RepeaterItem)themvaogio.Parent;
            //string soluong = ((TextBox)item.FindControl("txtsl")).Text;
            //
            string soluong = txtsl.Text;
            Int32 sl = Int32.Parse(soluong.ToString());
            DataTable dt = kn.laydata("select TENSANPHAM, DONGIA,TONKHO,HINHANH1,IDUSER from SANPHAM where IDSANPHAM='" + idsanpham + "'");
            string tensanpham = dt.Rows[0].Field<string>("TENSANPHAM");
            Decimal dongia = dt.Rows[0].Field<Decimal>("DONGIA");
            Int32 tonkho = dt.Rows[0].Field<Int32>("TONKHO");
            Int32 user = dt.Rows[0].Field<Int32>("IDUSER");

            string hinhanh = dt.Rows[0].Field<string>("HINHANH1");
            if (sl < 0 || sl >tonkho)
            {
                Response.Write("<script>alert('Số lượng phải lớn hơn 0 và phải nhỏ hơn "+ tonkho+"');</script>");
            }
            else
            {
                Server.Transfer("cart.aspx?action=add&id=" + idsanpham + "&ten=" + tensanpham + "&dongia=" + dongia + "&hinhanh1=" + hinhanh + "&soluong=" + soluong +  "&tonkho=" + tonkho + "&iduser=" + user);
            }
            
        }

        protected void btnMuaNgay_Click1(object sender, EventArgs e)
        {
            //mua ngay
        }
    }
}