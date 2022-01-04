using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.KhachHang_login
{
    public partial class QuanLyTTCaNhan : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            Repeater1.DataSource = kn.laydata("SELECT * FROM TAIKHOAN WHERE IDUSER=" + itndangnhap + "");
            Repeater1.DataBind();
        }
    }
}