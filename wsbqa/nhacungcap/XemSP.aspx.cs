using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.nhacungcap
{
    public partial class XemSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["MADANGNHAP"] == null || Session["kiemtradangnhap"].ToString() != "3")
            {
                Response.Redirect("../Khachhang/login.aspx");
            }
        }
    }
}