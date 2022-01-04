using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.admin
{
    public partial class ThemDMSP : System.Web.UI.Page
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
        protected void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            //them danh muc
            //gui yeu cau them danh muc
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            string tenDanhMuc = txtTenDanhMuc.Text;
            int kq = kn.xuly("INSERT INTO DANHMUCSANPHAM(TENDANHMUC,TINHTRANG,IDUSER) VALUES (N'" + tenDanhMuc + "',N'chờ xác nhận','" + itndangnhap + "')");
            if (kq > 0)//neu cap nhat duoc thi hien thong bao
            {
                Response.Write("<script>alert('Thêm thành công');</script>");
                txtTenDanhMuc.Text = "";
                bind();
            }
            else
            {
                Response.Write("<script>alert('Thêm không thành công');</script>");
            }
        }
    }
}