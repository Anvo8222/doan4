using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.admin
{
    public partial class XemTKKH : System.Web.UI.Page
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
            Repeater1.DataSource = kn.laydata("SELECT * FROM TAIKHOAN WHERE IDPHANQUYEN=2 and TRANGTHAI=N'đã kích hoạt' ORDER BY IDUSER DESC");
            Repeater1.DataBind();
        }
        protected void btnXoa_Click(object sender, EventArgs e)
        {
            //XÓA
            string message = "Bạn chắc muốn khóa tài khoản này?";
            string title = "khóa tài khoản";
            System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.YesNo;
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //btn huy
                string maUSer = ((Button)sender).CommandArgument;
                int kq = kn.xuly("UPDATE TAIKHOAN SET TRANGTHAI=N'đã khóa' WHERE IDUSER='" + maUSer + "'");

                if (kq > 0)//neu cap nhat duoc thi hien thong bao
                {
                    Response.Write("<script>alert('Xác nhận thành công');</script>");
                    Repeater1.DataSource = kn.laydata("SELECT * FROM TAIKHOAN WHERE IDPHANQUYEN=2 ORDER BY IDDANHMUC DESC");
                    Repeater1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('Xác nhận không thành công');</script>");
                }
            }
        }
    }
}