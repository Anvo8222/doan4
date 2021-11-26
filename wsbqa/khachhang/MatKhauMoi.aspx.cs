using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.khachhang
{
    public partial class MatKhauMoi : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTiepTuc_Click(object sender, EventArgs e)
        {
            string matkhau = txtPassword1.Text;
            string pass = wsbqa.MD5.ToMD5(matkhau);
            string email = Session["emailquenmk"].ToString();
            string sql = "UPDATE TAIKHOAN SET MATKHAU='" + pass + "' where EMAIL='" + email + "'";
            int kq = kn.xuly(sql);
            if (kq > 0)
            {
                Response.Write("<script>alert('Cập nhật Thành công!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Cập nhật không thành công!');</script>");
            }
        }
    }
}