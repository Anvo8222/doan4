using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.nhacungcap
{
    public partial class DoiMatKhauNCC : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            //doi mat khau
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            string pass = txtmk2.Text;
            string mk = wsbqa.MD5.ToMD5(pass);

            string sql = "UPDATE TAIKHOAN SET MATKHAU= '" + mk + "' WHERE IDUSER='" + itndangnhap + "'";
            int kq = kn.xuly(sql);

            if (kq > 0)//neu cap nhat duoc thi hien thong bao
            {
                Response.Write("<script>alert('Cập nhật thành công');</script>");
            }
            else
            {
                Response.Write("<script>alert('Cập nhật không thành công');</script>");
            }
        }
    }
}