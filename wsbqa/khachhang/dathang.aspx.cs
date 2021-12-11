using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace wsbqa.khachhang
{
    public partial class dathang : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        private readonly Random _random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["MADANGNHAP"] == null)
            {
                Response.Redirect("login.aspx");
            }
            if (!IsPostBack)
            {
                DataTable cart = new DataTable();
                if (Session["cart"] == null)
                {
                    txtTongTien.Text = "Không có sản phẩm nào";
                    phd_dathang.Visible = false;
                }
                else
                {
                    phd_dathang.Visible = true;
                    //Lấy thông tin giỏ hàng từ Session["cart"]
                    cart = Session["cart"] as DataTable;
                    DataTable dtcart = (DataTable)Session["cart"];
                    float total = 0;
                    for (int i = 0; i < dtcart.Rows.Count; i++)
                    {
                        total += Convert.ToSingle(dtcart.Rows[i]["Thanhtien"]);
                    }
                    txtTongTien.Text = string.Format("{0:N0}", total);

                }

                //Hiện thị thông tin giỏ hàng
                Repeater1.DataSource = cart;
                Repeater1.DataBind();

                //show pm
                //String ngaydathang = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime ngaydathang = DateTime.Now;
            DataTable cart = new DataTable();
            cart = Session["cart"] as DataTable;
            string idsanpham;
            string iduser = Session["MADANGNHAP"].ToString();
            string diachi = txtDiaChi.Text;
            string hoten = txtHoTen.Text;
            string sodienthoai = txtsdt.Text;
            int kq;
            //txtPhiShip.Text = ngaydathang.ToString();
            //chay cart

            //đặt hàng   (chưa xong)
            foreach (DataRow dtr in cart.Rows)
            {
                kq = kn.xuly("INSERT INTO DONHANG values ('" + ngaydathang + "', '" + diachi + "',N'Chờ xác nhận','" + sodienthoai + "','" + hoten + "','"+ iduser+"'");
                if (kq > 0)
                {
                    kn.xuly("insert into CHITIETDONHANG values ('" + int.Parse(dtr["Quantity"].ToString()) + "','"+ int.Parse(dtr["dongia"].ToString()));
                    Response.Write("<script>alert('ĐẶT HÀNG THÀNH CÔNG');</script>");
                }
                else
                {
                    Response.Write("<script>alert('ĐẶT HÀNG KHÔNG THÀNH CÔNG');</script>");
                }
            }
            Session["cart"] = null;
            Server.Transfer("dathang.aspx");
        }
    }
}