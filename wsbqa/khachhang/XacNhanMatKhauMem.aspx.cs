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
    public partial class XacNhanMatKhauMem : System.Web.UI.Page
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
            DateTime date = DateTime.Now;
            string ten = Session["ten"].ToString();
            string ho = Session["ho"].ToString();
            string hoten = ho + " " + ten;
            string matkhau = Session["matkhau"].ToString();
            string email = Session["email"].ToString();
            string sodienthoai = Session["sodienthoai"].ToString();
            string gioitinh = Session["gioitinh"].ToString();
            string diachi = Session["diachi"].ToString();
            string namsinh = Session["namsinh"].ToString();
            //mã hóa mật khẩu trước khi thêm vào database
            string pass = wsbqa.MD5.ToMD5(matkhau);

            //INSERT VÀO BẢNG USER
            int kq1 = kn.xuly("insert into TAIKHOAN(EMAIL,MATKHAU,HOTEN,NAMSINH,GIOITINH,SODIENTHOAI,DIACHI,IDPHANQUYEN,TRANGTHAI) values ('" + email + "' , '" + pass + "',N'" + hoten + "',"+namsinh+ ",N'" + gioitinh + "', '" + sodienthoai + "',N'" + diachi + "', 3,N'đã kích hoạt')");
            if (kq1 > 0)
            {
                Response.Write("<script>alert('đăng ký tài khoản mới thành công');</script>");
                Response.Redirect("login.aspx");
            }
            else
            {
                Response.Write("<script>alert('đăng ký tài khoản không thành công');</script>");
            }

        }
    }
}