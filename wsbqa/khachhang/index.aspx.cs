using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace wsbqa.khachhang
{
    public partial class index : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        static int page = 0;
        static int pagesize = 0;

        static int pageBlog = 0;
        static int pagesizeBlog = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["con"] = @"Data Source=NGUYEN_AN\SQLEXPRESS;Initial Catalog=CSDLDOAN4;Integrated Security=True";
            if (!IsPostBack)
            {
                bind();
            }
        }
        void bind()
        {
            Repeater1.DataSource = kn.laydata("SELECT top 12 * FROM SANPHAM,TAIKHOAN WHERE SANPHAM.IDUSER=TAIKHOAN.IDUSER ORDER BY IDSANPHAM DESC");
            Repeater1.DataBind();
            string con = Session["con"].ToString();
            string query = "SELECT * FROM SANPHAM,TAIKHOAN WHERE SANPHAM.IDUSER=TAIKHOAN.IDUSER ORDER BY IDSANPHAM DESC";
            SqlConnection connection = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            //dem soluong
            pagesize = ds.Tables[0].Rows.Count;
            DataTable dt = ds.Tables[0];
            PagedDataSource pg = new PagedDataSource();
            pg.DataSource = dt.DefaultView;
            pg.AllowPaging = true;
            pg.CurrentPageIndex = page;
            pg.PageSize = 8;
            btnPrev2.Enabled = !pg.IsFirstPage;
            btnPrev1.Enabled = !pg.IsFirstPage;
            btnNext1.Enabled = !pg.IsLastPage;
            btnNext2.Enabled = !pg.IsLastPage;
            Repeater1.DataSource = pg;
            Repeater1.DataBind();
            connection.Close();
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //link buutton
            string maSanPham = ((LinkButton)sender).CommandArgument;
            Session["masanpham"] = maSanPham;
            Response.Redirect("./ChiTietSanPham.aspx");
        }
        protected void btnPrev2_Click(object sender, EventArgs e)
        {
            page = 0;
            bind();
        }

        protected void btnPrev1_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {

            }
            else
            {
                page = page - 1;
                bind();
            }
        }

        protected void btnNext1_Click(object sender, EventArgs e)
        {
            page = page + 1;
            bind();
        }

        protected void btnNext2_Click(object sender, EventArgs e)
        {
            page = pagesize - 1;
            bind();
        }

        
    }
}