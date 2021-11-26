using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace wsbqa.khachhang
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable cart = new DataTable();
                if (Session["cart"] == null)
                {
                    //Nếu chưa có giỏ hàng, tạo giỏ hàng thông qua DataTable với 4 cột chính
                    //ID(Mã sản phẩm), Name(Tên sản phẩm)
                    // Quantity(Số lượng)
                    cart.Columns.Add("ID");
                    cart.Columns.Add("HINHANH");
                    cart.Columns.Add("Name");
                    cart.Columns.Add("Dongia");
                    cart.Columns.Add("Quantity");
                    cart.Columns.Add("Thanhtien");
                    //Sau khi tạo xong thì lưu lại vào session
                    Session["cart"] = cart;
                }
                else
                {
                    DataTable dtcart = (DataTable)Session["cart"];
                    float total = 0;
                    for (int i = 0; i < dtcart.Rows.Count; i++)
                    {
                        total += Convert.ToSingle(dtcart.Rows[i]["Thanhtien"]);
                    }
                    Literal1.Text = string.Format("{0:N0}", total);
                    //Lấy thông tin giỏ hàng từ Session["cart"]
                    cart = Session["cart"] as DataTable;
                }
                if (!String.IsNullOrEmpty(Request.QueryString["action"]))
                {
                    if (Request.QueryString["action"] == "add")
                    {
                        string id = Request.QueryString["id"];
                        string name = Request.QueryString["ten"];
                        string hinhanh = Request.QueryString["hinhanh1"];
                        int tonkho = Int32.Parse(Request.QueryString["tonkho"]) ;
                        Double dongia = Double.Parse(Request.QueryString["dongia"]);
                        //String anh = Request.QueryString["anh"];
                        //int soluong = 0;
                        //if (int.TryParse(Request.QueryString["number"], out soluong)) ;
                        int soluong = Int32.Parse(Request.QueryString["soluong"]); 
                        double thanhtien = soluong * dongia;
                        //Kiểm tra xem đã có sản phẩm trong giỏ hàng chưa ?
                        //Nếu chưa thì thêm bản ghi mới vào giỏ hàng với số lượng Quantity là 1
                        //Nếu có thì tăng quantity lên 1
                        bool isExisted = false;
                        foreach (DataRow dr in cart.Rows)
                        {

                            if (dr["ID"].ToString() == id)
                            {
                                double thanhtien1 = thanhtien;
                                dr["Quantity"] = int.Parse(dr["Quantity"].ToString()) + soluong;
                                dr["dongia"] = double.Parse(dr["dongia"].ToString()) + dongia;
                                dr["Thanhtien"] = int.Parse(dr["Quantity"].ToString()) * Double.Parse(Request.QueryString["dongia"]);
                                isExisted = true;
                                break;
                            }

                        }

                        if (!isExisted)//Chưa có sản phẩm trong giỏ hàng
                        {
                            DataRow dr = cart.NewRow();
                            dr["ID"] = id;
                            dr["Name"] = name;
                            dr["Dongia"] = dongia;
                            dr["Quantity"] = soluong;
                            dr["HINHANH"] = hinhanh;
                            dr["Thanhtien"] = dongia * soluong;

                            cart.Rows.Add(dr);
                        }
                        //Lưu lại thông tin giỏ hàng mới nhất vào session["Cart"]
                        Session["cart"] = cart;
                        //Quay lai trang chu
                        Response.Redirect("Cart.aspx");
                    }
                }

                //Hiện thị thông tin giỏ hàng
                GridView1.DataSource = cart;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            DataTable cart = Session["cart"] as DataTable;
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = cart;
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            DataTable cart = Session["cart"] as DataTable;
            GridView1.EditIndex = -1;//không lấy giá trị cột nào hết
            GridView1.DataSource = cart;
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                DataTable cart = Session["cart"] as DataTable;
                string quantity = e.NewValues["Quantity"].ToString();
                string id = e.NewValues["ID"].ToString();
                foreach (DataRow dr in cart.Rows)
                {
                    //Kiểm tra mã sản phẩm phù hợp để gán số lượng khách hàng mua
                    if (dr["ID"].ToString() == id)
                    {
                        dr["Quantity"] = int.Parse(quantity.ToString());

                        dr["Thanhtien"] = int.Parse(dr["Quantity"].ToString()) * double.Parse(dr["dongia"].ToString());
                        break;
                    }
                }
                //Lưu lại vào Session
                Session["cart"] = cart;
                //Hiển thị giỏ hàng với thông tin mới
                GridView1.DataSource = cart;
                GridView1.DataBind();
                Response.Redirect("cart.aspx");
            }
            catch
            {
               
            }
        }

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            string id = e.Values["ID"].ToString();
            string message = "Bạn chắc muốn xóa sản phẩm?";
            string title = "Xóa sản phẩm";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            //Duyệt qua Giỏ hàng và xóa sản phẩm phù hợp
            if (result == DialogResult.Yes)
            {
                DataTable cart = Session["cart"] as DataTable;
                foreach (DataRow dr in cart.Rows)
                {
                    //Kiểm tra mã sản phẩm phù hợp để tăng số lượng
                    if (dr["ID"].ToString() == id)
                    {
                        dr.Delete();
                        break;
                    }

                }

                //Lưu lại vào Session
                Session["cart"] = cart;
                //Hiển thị giỏ hàng với thông tin mới
                GridView1.DataSource = cart;
                GridView1.DataBind();
                Response.Redirect("cart.aspx");
            }
        }
    }
}