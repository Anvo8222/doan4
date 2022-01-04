using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace wsbqa.nhacungcap
{
    public partial class ThemSanPham : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropDownList();
            }
        }
        private void BindDropDownList()
        {
            try
            {
                ddlDanhMuc.DataSource = kn.laydata("SELECT * FROM DANHMUCSANPHAM WHERE TINHTRANG=N'đã xác nhận' ORDER BY IDDANHMUC DESC");
                ddlDanhMuc.DataValueField = "IDDANHMUC";
                ddlDanhMuc.DataTextField = "TENDANHMUC";
                ddlDanhMuc.DataBind();
            }
            catch { }
        }

        protected void btThemMoi_Click(object sender, EventArgs e)
        {
            //nut them moi san pham
            string tonkho = txtSoLuong.Text;
            string dongia = txtGia.Text;
            string tenSP = txtTemSanPham.Text;
            string danhMuc = ddlDanhMuc.SelectedValue;
            int iddanhmuc = Int32.Parse(danhMuc);
            string hinh = txtHinh.Text;
            int tk = Int32.Parse(tonkho);
            double gia = double.Parse(dongia);
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            string sql = "insert into SANPHAM(TENSANPHAM,TONKHO,DONGIA,HINHANH1,IDDANHMUC,IDUSER) values (N'"+ tenSP + "' ," + tk + "," + gia + ",'" + hinh + "'," + iddanhmuc + ","+ itndangnhap + ")";
            int kq = kn.xuly(sql);
            if (kq > 0)
            {
                Response.Write("<script>alert('Thêm mới sản phẩm thành công');</script>");

            }
            else
            {
                Response.Write("<script>alert('Thêm mới sản phẩm không thành công');</script>");
            }

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            //nut save
            if (fuphinh.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(fuphinh.FileName);
                    fuphinh.SaveAs(@"D:\ky1_nam4\CDIO\project\wsbqa\wsbqa\img\" + fuphinh.FileName);
                    lbltb.Text = "Upload status: File uploaded!";
                    txtHinh.Text = fuphinh.FileName;

                }
                catch (Exception ex)
                {
                    lbltb.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }

            }
        }
    }
}