using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace wsbqa.KhachHang_login
{
    public partial class YeuCauThemDM : System.Web.UI.Page
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
            GridView1.DataSource = kn.laydata("SELECT * FROM DANHMUCSANPHAM WHERE TINHTRANG=N'chờ xác nhận' order by IDDANHMUC DESC");
            GridView1.DataBind();//load dữ liêu lên đối tượng
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //gui yeu cau them danh muc
            string madangnhap = Session["MADANGNHAP"].ToString();
            int itndangnhap = Int32.Parse(madangnhap);
            string tenDanhMuc = txtTenDanhMuc.Text;
            int kq = kn.xuly("INSERT INTO DANHMUCSANPHAM(TENDANHMUC,TINHTRANG,IDUSER) VALUES (N'"+ tenDanhMuc+"',N'chờ xác nhận','"+ itndangnhap+"')");
            if (kq > 0)//neu cap nhat duoc thi hien thong bao
            {
                Response.Write("<script>alert('Gửi yêu cầu thành công');</script>");
                txtTenDanhMuc.Text="";
                
                datafill();
            }
            else
            {
                Response.Write("<script>alert('Gửi yêu cầu không thành công');</script>");
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;//không lấy giá trị cột nào hết
            GridView1.DataSource = kn.laydata("SELECT * FROM DANHMUCSANPHAM WHERE TINHTRANG=N'chờ xác nhận' order by IDDANHMUC DESC");
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //chức năng edit
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = kn.laydata("SELECT * FROM DANHMUCSANPHAM WHERE TINHTRANG=N'chờ xác nhận' order by IDDANHMUC DESC");
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //update
            string iddanhmuc = e.NewValues["IDDANHMUC"].ToString();
            string tendanhmuc = e.NewValues["TENDANHMUC"].ToString();
            

            string sql = "update DANHMUCSANPHAM set TENDANHMUC = '" + tendanhmuc + "' WHERE IDDANHMUC='" + iddanhmuc + "'";
            int kq = kn.xuly(sql);

            if (kq > 0)//neu cap nhat duoc thi hien thong bao
            {
                Response.Write("<script>alert('Cập nhật thanh công');</script>");
                GridView1.DataSource = kn.laydata("SELECT * FROM DANHMUCSANPHAM WHERE TINHTRANG=N'chờ xác nhận' order by IDDANHMUC DESC");
                GridView1.EditIndex = -1;
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Cập nhật không thanh công');</script>");
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //DELETE
            string madanhmuc = e.Values["IDDANHMUC"].ToString();
            string message = "Bạn chắc muốn xóa YÊU CẦU?";
            string title = "XÓA YÊU CẦU";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int kq = kn.xuly("delete from DANHMUCSANPHAM where IDDANHMUC = '" + madanhmuc + "'");
                if (kq > 0) //neu cap nhat duoc thi hien thi thong bao
                {
                    Response.Write("<script>alert'bạn xóa thành công');</script>");
                    GridView1.DataSource = kn.laydata("SELECT * FROM DANHMUCSANPHAM WHERE TINHTRANG=N'chờ xác nhận' order by IDDANHMUC DESC");
                    GridView1.DataBind();
                }

                else
                {
                    Response.Write("<script>alert('Xóa không thanh công');</script>");

                }
            }
        }
    }
}