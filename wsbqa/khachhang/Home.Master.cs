using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.khachhang
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Tendangnhap"] != null && Session["kiemtradangnhap"].ToString() == "1")
            {
                // đã đăng nhập bằng tk admin
                PHDAdmin.Visible = true;
                PHDDangNhap.Visible = false;
                PHDHoSoCaNhan.Visible = false;
                PHDDangXuat.Visible = false;
            }
            else if (Session["Tendangnhap"] != null && Session["kiemtradangnhap"].ToString() == "2")
            {
                // đã đăng nhập bằng tài khoảng employer
                PHDAdmin.Visible = false;
                PHDDangNhap.Visible = false;
                PHDDangXuat.Visible = true;
                PHDHoSoCaNhan.Visible = true;

            }
            else if (Session["Tendangnhap"] != null && Session["kiemtradangnhap"].ToString() == "3")
            {
                // đã đăng nhập bằng tài khoảng member
                PHDAdmin.Visible = false;
                PHDHoSoCaNhan.Visible = false;
                PHDDangNhap.Visible = false;
                PHDDangXuat.Visible = true;
            }
            else
            {
                // chua dang nhap
                PHDDangNhap.Visible = true;
                PHDDangXuat.Visible = false;
                PHDAdmin.Visible = false;
                PHDHoSoCaNhan.Visible = false;
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            //dang xuat
            Session["Tendangnhap"] = "";
            Session["kiemtradangnhap"] = "";
            Session["MADANGNHAP"] = "";
            Response.Redirect("index.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //BTN TIM KIEM
            Session["name"] = TextBox1.Text;
            if (DropDownList1.SelectedItem.Value.ToString() != "0")
            {
                Session["giatien"] = DropDownList1.SelectedItem.Value.ToString();
            }
            if (DropDownList2.SelectedItem.Value.ToString() != "0")
            {
                Session["madanhmuc"] = DropDownList2.SelectedItem.Value.ToString();
            }
            Server.Transfer("timkiem.aspx");

        }

        protected void btnhuy_Click(object sender, EventArgs e)
        {
            //BTN HUY
            TextBox1.Text = null;
            DropDownList1.SelectedItem.Value = "0";
            DropDownList2.SelectedItem.Value = "0";
        }
    }
}