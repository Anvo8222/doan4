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
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["MADANGNHAP"] == null || Session["kiemtradangnhap"].ToString() != "3")
            {
                Response.Redirect("../Khachhang/login.aspx");
            }
            if (!IsPostBack)
            {
                bind();
            }

        }
        void bind()
        {
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            Repeater1.DataSource = kn.laydata("SELECT * FROM SANPHAM,TAIKHOAN,DANHMUCSANPHAM WHERE SANPHAM.IDDANHMUC=DANHMUCSANPHAM.IDDANHMUC AND SANPHAM.IDUSER="+ itndangnhap + " AND DANHMUCSANPHAM.IDUSER=TAIKHOAN.IDUSER ORDER BY IDSANPHAM DESC");
            Repeater1.DataBind();
        }

    }
}