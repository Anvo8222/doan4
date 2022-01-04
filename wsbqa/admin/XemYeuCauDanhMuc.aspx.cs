using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.admin
{
    public partial class XemYeuCauDanhMuc : System.Web.UI.Page
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
            Repeater1.DataSource = kn.laydata("SELECT * FROM DANHMUCSANPHAM WHERE TINHTRANG=N'chờ xác nhận' ORDER BY IDDANHMUC DESC");
            Repeater1.DataBind();
        }
        protected void btnXacNhan_Click(object sender, EventArgs e)
        {
            //xac nhan
            string maDM = ((Button)sender).CommandArgument;


            int kq = kn.xuly("UPDATE DANHMUCSANPHAM SET TINHTRANG=N'đã xác nhận' WHERE IDDANHMUC='" + maDM + "'");

            if (kq > 0)//neu cap nhat duoc thi hien thong bao
            {
                Response.Write("<script>alert('Xác nhận thành công');</script>");
                Repeater1.DataSource = kn.laydata("SELECT * FROM DANHMUCSANPHAM WHERE TINHTRANG=N'chờ xác nhận' ORDER BY IDDANHMUC DESC");
                Repeater1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Xác nhận không thành công');</script>");
            }
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            //huy

            string message = "Bạn chắc muốn hủy?";
            string title = "hủy";
            System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.YesNo;
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //btn huy
                string maDM = ((Button)sender).CommandArgument;
                int kq = kn.xuly("UPDATE DANHMUCSANPHAM SET TINHTRANG=N'đã hủy' WHERE IDDANHMUC='" + maDM + "'");

                if (kq > 0)//neu cap nhat duoc thi hien thong bao
                {
                    Response.Write("<script>alert('Xác nhận thành công');</script>");
                    Repeater1.DataSource = kn.laydata("SELECT * FROM DANHMUCSANPHAM WHERE TINHTRANG=N'chờ xác nhận' ORDER BY IDDANHMUC DESC");
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