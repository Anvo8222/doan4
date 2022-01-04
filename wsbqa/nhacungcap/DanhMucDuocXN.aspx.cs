using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.nhacungcap
{
    public partial class DanhMucDuocXN : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                datafill();
            }
        }
        private void datafill()
        {
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            Repeater1.DataSource = kn.laydata("SELECT * FROM DANHMUCSANPHAM WHERE TINHTRANG=N'đã xác nhận' AND IDUSER='"+ itndangnhap+"' order by IDDANHMUC DESC");
            Repeater1.DataBind();//load dữ liêu lên đối tượng
        }
    }
}