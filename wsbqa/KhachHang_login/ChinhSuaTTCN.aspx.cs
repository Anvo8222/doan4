using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.KhachHang_login
{
    public partial class ChinhSuaTTCN : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //cap nhat
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);


            string hoten = txtHoTen.Text;
            string namSinh = txtNamSinh.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;

            double sodienthoai = double.Parse(sdt);
            int ns = Int32.Parse(namSinh);


            string sql = "UPDATE TAIKHOAN SET HOTEN= N'" + hoten + "', NAMSINH =" + ns + ", SODIENTHOAI = " + sodienthoai + ", DIACHI = N'" + diaChi + "' WHERE IDUSER='" + itndangnhap + "'";
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