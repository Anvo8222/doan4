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
    public partial class XacNhanQuenMK : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            string macode = txtMaXn.Text;

            if (macode == Session["codeQuenMK"].ToString())
            {

                Response.Redirect("MatKhauMoi.aspx");

            }
            else
            {
                Response.Write("<script>alert('Sai mã code, vui lòng nhập lại!');</script>");
            }
        }
    }
}