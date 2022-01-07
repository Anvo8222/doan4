using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace wsbqa.nhacungcap
{
    public partial class XemDonDaXN : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                datafill();
            }
        }
        private void datafill()
        {
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            Repeater1.DataSource = kn.laydata("select DONHANG.*, sum(CHITIETDONHANG.SOLUONG) as TONGSL,sum(CHITIETDONHANG.DONGIA * CHITIETDONHANG.SOLUONG) as TONGDG from  DONHANG LEFT JOIN CHITIETDONHANG ON DONHANG.IDDONHANG = CHITIETDONHANG.IDDONHANG LEFT JOIN SANPHAM ON SANPHAM.IDSANPHAM = CHITIETDONHANG.IDSANPHAM WHERE DONHANG.TRANGTHAI=N'đã xác nhận' or DONHANG.TRANGTHAI=N'đang giao' or DONHANG.TRANGTHAI=N'đã giao' and SANPHAM.IDUSER = " + itndangnhap + " GROUP BY DONHANG.IDDONHANG, DONHANG.NGAYLAP,DONHANG.DIACHIKH,DONHANG.TRANGTHAI,DONHANG.SDT,DONHANG.HOTEN,DONHANG.IDUSER;");
            Repeater1.DataBind();//load dữ liêu lên đối tượng
        }

        protected void btnXacNhan_Click(object sender, EventArgs e)
        {
            //cap nhat
        }

        protected void btnView_Click(object sender, EventArgs e)
        {


           
        }

        protected void btnView_Click1(object sender, EventArgs e)
        {
            //linkbutton view
            string maDonHang = ((LinkButton)sender).CommandArgument;
            Session["maDonHang"] = maDonHang;
            Response.Redirect("./TrangThaiDH.aspx");
        }
    }
}