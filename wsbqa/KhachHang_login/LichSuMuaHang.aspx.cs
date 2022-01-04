using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.KhachHang_login
{
    public partial class LichSuMuaHang : System.Web.UI.Page
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
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            Repeater1.DataSource = kn.laydata("select DONHANG.IDDONHANG,NGAYLAP,DIACHIKH,TENSANPHAM,HINHANH1,CHITIETDONHANG.DONGIA,SOLUONG,  CHITIETDONHANG.SOLUONG * CHITIETDONHANG.DONGIA as TONG,DONHANG.TRANGTHAI from TAIKHOAN,DONHANG,CHITIETDONHANG,SANPHAM WHERE CHITIETDONHANG.IDDONHANG=DONHANG.IDDONHANG AND CHITIETDONHANG.IDSANPHAM=SANPHAM.IDSANPHAM AND DONHANG.IDUSER=2 AND TAIKHOAN.IDUSER="+ itndangnhap + " AND DONHANG.TRANGTHAI=N'chờ xác nhận'");
            Repeater1.DataBind();//load dữ liêu lên đối tượng
        }
            protected void btnHuy_Click(object sender, EventArgs e)
        {

            //xoa
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            string message = "Bạn chắc muốn hủy?";
            string title = "hủy";
            System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.YesNo;
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //btn huy
                string maDH = ((Button)sender).CommandArgument;
                int kq = kn.xuly("UPDATE DONHANG SET TRANGTHAI = N'đã hủy' WHERE IDDONHANG = '" + maDH + "'");

                if (kq > 0)//neu cap nhat duoc thi hien thong bao
                {
                    Response.Write("<script>alert('hủy đơn thành công');</script>");
                    Repeater1.DataSource = kn.laydata("select DONHANG.IDDONHANG,NGAYLAP,DIACHIKH,TENSANPHAM,HINHANH1,CHITIETDONHANG.DONGIA,SOLUONG,  CHITIETDONHANG.SOLUONG * CHITIETDONHANG.DONGIA as TONG,DONHANG.TRANGTHAI from TAIKHOAN,DONHANG,CHITIETDONHANG,SANPHAM WHERE CHITIETDONHANG.IDDONHANG=DONHANG.IDDONHANG AND CHITIETDONHANG.IDSANPHAM=SANPHAM.IDSANPHAM AND DONHANG.IDUSER=2 AND TAIKHOAN.IDUSER=" + itndangnhap + " AND DONHANG.TRANGTHAI=N'chờ xác nhận'");
                    Repeater1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('Không thể xóa đơn này');</script>");
                }
            }

        }
    }
}