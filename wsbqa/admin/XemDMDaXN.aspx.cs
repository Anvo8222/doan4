using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.admin
{
    public partial class XemDMDaXN : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }
        void bind()
        {
            Repeater1.DataSource = kn.laydata("SELECT * FROM DANHMUCSANPHAM WHERE TINHTRANG=N'đã xác nhận' ORDER BY IDDANHMUC DESC");
            Repeater1.DataBind();
        }
    }
}