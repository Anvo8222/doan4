using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace wsbqa.nhacungcap
{
    public partial class TrangThaiDH : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            fillData();
        }
        public void fillData()
        {
          
                string maDonHang = Session["maDonHang"].ToString();
                string madangnhap = Session["MADANGNHAP"].ToString();
                int intmaDonHang = Int32.Parse(maDonHang);
                Repeater1.DataSource = kn.laydata("select DONHANG.*, sum(CHITIETDONHANG.SOLUONG) as TONGSL,sum(CHITIETDONHANG.DONGIA * CHITIETDONHANG.SOLUONG) as TONGDG from  DONHANG LEFT JOIN CHITIETDONHANG ON DONHANG.IDDONHANG = CHITIETDONHANG.IDDONHANG LEFT JOIN SANPHAM ON SANPHAM.IDSANPHAM = CHITIETDONHANG.IDSANPHAM WHERE  DONHANG.IDDONHANG = "+intmaDonHang+" GROUP BY DONHANG.IDDONHANG, DONHANG.NGAYLAP,DONHANG.DIACHIKH,DONHANG.TRANGTHAI,DONHANG.SDT,DONHANG.HOTEN,DONHANG.IDUSER;");
                Repeater1.DataBind();

           
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //cap nhat

            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            string iddh = Session["maDonHang"].ToString();
            int kq = kn.xuly("UPDATE DONHANG SET TRANGTHAI=N'"+ddl.SelectedValue+"' WHERE IDDONHANG='" + iddh + "'");

            if (kq > 0)//neu cap nhat duoc thi hien thong bao
            {
                Response.Write("<script>alert('Xác nhận thành công');</script>");
                fillData();
            }
            else
            {
                Response.Write("<script>alert('Xác nhận không thành công');</script>");
            }
        }
    }
}