using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.KhachHang_login
{
    public partial class DonHangDaGiao : System.Web.UI.Page
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
            Repeater1.DataSource = kn.laydata("select DONHANG.IDDONHANG,NGAYLAP,DIACHIKH,TENSANPHAM,HINHANH1,CHITIETDONHANG.DONGIA,SOLUONG,  CHITIETDONHANG.SOLUONG * CHITIETDONHANG.DONGIA as TONG,DONHANG.TRANGTHAI from TAIKHOAN,DONHANG,CHITIETDONHANG,SANPHAM WHERE CHITIETDONHANG.IDDONHANG=DONHANG.IDDONHANG AND CHITIETDONHANG.IDSANPHAM=SANPHAM.IDSANPHAM AND DONHANG.IDUSER=2 AND TAIKHOAN.IDUSER=" + itndangnhap + " AND DONHANG.TRANGTHAI=N'đã giao'");
            Repeater1.DataBind();//load dữ liêu lên đối tượng
        }
    }
}