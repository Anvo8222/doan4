using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.khachhang
{
    public partial class XacNhanMatKhau : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            string macode = txtMaXn.Text;

            if (macode == Session["code"].ToString())
            {

                insert();

            }
            else
            {
                Response.Write("<script>alert('Sai mã code, vui lòng nhập lại!');</script>");
            }
        }

        private void insert()
        {
            string matkhau = Session["matkhau"].ToString();
            string email = Session["email"].ToString();
            //mã hóa mật khẩu trước khi thêm vào database
            string pass = wsbqa.MD5.ToMD5(matkhau);
            int kq = kn.xuly("insert into TAIKHOAN(EMAIL,MATKHAU,TRANGTHAI,IDPHANQUYEN) values ('" + email + "' , '" + pass + "',N'đã kích hoạt', 2)");

            if (kq > 0) // neu cap nhat duoc thi hien thi khong bao
            {
                Response.Write("<script>alert('đăng ký tài khoản mới thành công');</script>");
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("<script>alert('đăng ký tài khoản không thành công');</script>");
            }

        }
    }
}