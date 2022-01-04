using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsbqa.admin
{
    public partial class ThemTKNhaCungCap : System.Web.UI.Page
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
            GridView1.DataSource = kn.laydata("SELECT * FROM TAIKHOAN ORDER BY IDUSER DESC");
            GridView1.DataBind();
        }
        protected void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt = kn.laydata("select EMAIL from TAIKHOAN  WHERE EMAIL='" + txtEmail.Text + "'");
            string pass = wsbqa.MD5.ToMD5(txtMatKhau.Text);
            if (dt.Rows.Count == 0)
            {
                int kq = kn.xuly("insert into TAIKHOAN(EMAIL,MATKHAU,HOTEN,NAMSINH,GIOITINH, SODIENTHOAI,DIACHI,IDPHANQUYEN,TRANGTHAI) " +
                    "values ('" + txtEmail.Text + "' , '" + pass + "' , N'" + txtHoTen.Text + "' , '" + txtNamSinh.Text + "', N'" + txtGioiTinh.Text
                    + "','" + txtSoDienThoai.Text + "', N'" + txtDiaChi.Text + "',3,N'đã kích hoạt')");
                if (kq > 0) {
                    Response.Write("<script>alert('Thêm mới thành công');</script>");
                    bind();

                } // neu cap nhat duoc thi hien thi khong bao

                else
                    Response.Write("<script>alert('Thêm mới không thành công');</script>");
            }
            else Response.Write("<script>alert('Email đã tồn tại');</script>");
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;//không lấy giá trị cột nào hết
            GridView1.DataSource = kn.laydata("SELECT * FROM TAIKHOAN  ORDER BY IDUSER DESC");
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = kn.laydata("SELECT * FROM TAIKHOAN  ORDER BY IDUSER DESC");
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //update
            string id = e.NewValues["IDUSER"].ToString();
            string hoten = e.NewValues["HOTEN"].ToString();
            string namsinh = e.NewValues["NAMSINH"].ToString();
            string gioitinh = e.NewValues["GIOITINH"].ToString();
            string sdt = e.NewValues["SODIENTHOAI"].ToString();
            string diachi = e.NewValues["DIACHI"].ToString();

            string sql = "update TAIKHOAN set HOTEN = N'" + hoten + "',NAMSINH = '" + namsinh + "',GIOITINH = N'" + gioitinh + "',SODIENTHOAI = '" + sdt + "',DIACHI = '" + diachi + "' WHERE IDUSER='" + id + "'";
            int kq = kn.xuly(sql);

            if (kq > 0)//neu cap nhat duoc thi hien thong bao
            {
                Response.Write("<script>alert('Cập nhật thanh công');</script>");
                GridView1.DataSource = kn.laydata("SELECT * FROM TAIKHOAN  ORDER BY IDUSER DESC");
                GridView1.EditIndex = -1;
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Cập nhật không thanh công');</script>");
            }
        }
    }
}