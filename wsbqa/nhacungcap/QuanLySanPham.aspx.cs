using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace wsbqa.nhacungcap
{
    public partial class QuanLySanPham : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                string madangnhap = Session["MADANGNHAP"].ToString();
                int itndangnhap = Int32.Parse(madangnhap);
                GridView1.DataSource = kn.laydata("SELECT * FROM SANPHAM WHERE IDUSER=" + itndangnhap + " order by IDSANPHAM DESC");
                GridView1.DataBind();//load dữ liêu lên đối tượng
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

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if( txtHinh.Text=="" /*e.NewValues["HINHANH1"].ToString()*/)
            {
                string madangnhap = Session["MADANGNHAP"].ToString();
                int itndangnhap = Int32.Parse(madangnhap);
                string idsanpham = e.NewValues["IDSANPHAM"].ToString();
                string tensanpham = e.NewValues["TENSANPHAM"].ToString();
                string tonkho = e.NewValues["TONKHO"].ToString();
                string dongia = e.NewValues["DONGIA"].ToString();


                string iddanhmuc = e.NewValues["IDDANHMUC"].ToString();

                string sql = "update SANPHAM set IDSANPHAM = '" + idsanpham + "', TENSANPHAM = N'" + tensanpham + "', TONKHO = '" + tonkho + "', DONGIA = '" + dongia + "' , IDDANHMUC = '" + iddanhmuc + "' WHERE IDSANPHAM='" + idsanpham + "'";
                int kq = kn.xuly(sql);

                if (kq > 0)//neu cap nhat duoc thi hien thong bao
                {
                    Response.Write("<script>alert('Cập nhật thanh công');</script>");
                    GridView1.DataSource = kn.laydata("SELECT * FROM SANPHAM WHERE IDUSER=" + itndangnhap + " order by IDSANPHAM DESC");
                    GridView1.EditIndex = -1;
                    GridView1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('Cập nhật không thanh công');</script>");
                }
            }
            else
            {
                //
                string madangnhap = Session["MADANGNHAP"].ToString();
                int itndangnhap = Int32.Parse(madangnhap);
                string idsanpham = e.NewValues["IDSANPHAM"].ToString();
                string tensanpham = e.NewValues["TENSANPHAM"].ToString();
                string tonkho = e.NewValues["TONKHO"].ToString();
                string dongia = e.NewValues["DONGIA"].ToString();


                string iddanhmuc = e.NewValues["IDDANHMUC"].ToString();

                string sql = "update SANPHAM set IDSANPHAM = '" + idsanpham + "', TENSANPHAM = N'" + tensanpham + "', HINHANH1 = N'" + txtHinh.Text + "', TONKHO = '" + tonkho + "', DONGIA = '" + dongia + "' , IDDANHMUC = '" + iddanhmuc + "' WHERE IDSANPHAM='" + idsanpham + "'";
                int kq = kn.xuly(sql);

                if (kq > 0)//neu cap nhat duoc thi hien thong bao
                {
                    Response.Write("<script>alert('Cập nhật thanh công');</script>");
                    GridView1.DataSource = kn.laydata("SELECT * FROM SANPHAM WHERE IDUSER=" + itndangnhap + " order by IDSANPHAM DESC");
                    GridView1.EditIndex = -1;
                    GridView1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('Cập nhật không thanh công');</script>");
                }
            }
            
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = kn.laydata("SELECT * FROM SANPHAM WHERE IDUSER=" + itndangnhap + " order by IDSANPHAM DESC");
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            GridView1.EditIndex = -1;//không lấy giá trị cột nào hết
            GridView1.DataSource = kn.laydata("SELECT * FROM SANPHAM WHERE IDUSER=" + itndangnhap + " order by IDSANPHAM DESC");
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            //delete
            string masanpham = e.Values["IDSANPHAM"].ToString();
            string message = "Bạn chắc muốn xóa sản phẩm?";
            string title = "Xóa sản phẩm";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int kq = kn.xuly("delete from SANPHAM where IDSANPHAM = '" + masanpham + "'");
                if (kq > 0) //neu cap nhat duoc thi hien thi thong bao
                {
                    Response.Write("<script>alert'bạn xóa thành công');</script>");
                    GridView1.DataSource = kn.laydata("SELECT * FROM SANPHAM WHERE IDUSER=" + itndangnhap + " order by IDSANPHAM DESC");
                    GridView1.DataBind();
                }

                else
                {
                    Response.Write("<script>alert('Xóa không thành công');</script>");

                }
            }
        }
    }
}