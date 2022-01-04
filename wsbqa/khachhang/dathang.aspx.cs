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

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
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
            //Trạng thái ( 1: chờ xác nhận, 2: đang giao , 3: đã giao)
            //đặt hàng   (chưa xong)
            int num = RandomNumber(1, 100000);
            string sql_donhang = "SET IDENTITY_INSERT DONHANG ON; INSERT INTO DONHANG (IDDONHANG, NGAYLAP, DIACHIKH,TRANGTHAI,SDT,HOTEN,IDUSER) values ("
                + num + ", '" + ngaydathang + "', N'" + diachi + "',N'chờ xác nhận','" + sodienthoai + "',N'" + hoten + "','" + iduser + "'); SET IDENTITY_INSERT DONHANG OFF;";
            kq = kn.xuly(sql_donhang);
            bool isSuccess = true;
            foreach (DataRow dtr in cart.Rows)
            {     
                if (kq > 0)
                {
                    string tykm = "1/2"; //xem lai  
                    kn.xuly("insert into CHITIETDONHANG values ('" + int.Parse(dtr["Quantity"].ToString()) + "','"+ int.Parse(dtr["dongia"].ToString())
                        + "','" + tykm + "','" + int.Parse(dtr["ID"].ToString()) + "','" + num + "')");
                }
                else
                {
                    Response.Write("<script>alert('ĐẶT HÀNG KHÔNG THÀNH CÔNG');</script>");
                    isSuccess = false;
                }
            }
            if(isSuccess == true)
            {
                Response.Write("<script>alert('ĐẶT HÀNG THÀNH CÔNG');</script>");
                Session["cart"] = null;
                Server.Transfer("./cart.aspx");
            }
        }
    }
}