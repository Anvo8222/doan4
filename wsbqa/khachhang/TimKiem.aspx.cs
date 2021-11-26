using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace wsbqa.khachhang
{
    public partial class TimKiem : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                filldatalist();
            }
        }
        protected void filldatalist()
        {
            if(Session["madanhmuc"] == null && Session["giatien"] == null && Session["name"] == null)
            {
                DataTable dt = kn.laydata("select * from SANPHAM");
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
           else if (Session["madanhmuc"] == null && Session["giatien"] == null)
            {
                String timkiemnd = Session["name"].ToString();
                Session["name"] = null;
                DataTable dt = kn.laydata("select * from SANPHAM where TENSANPHAM like '%" + timkiemnd + "%'");
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
            else if (Session["madanhmuc"] != null && Session["giatien"] == null)
            {
                String timkiemnd = Session["name"].ToString();
                Session["name"] = null;
                String madanhmuc = Session["madanhmuc"].ToString();
                Session["madanhmuc"] = null;
                DataTable dt = kn.laydata("select * from SANPHAM where TENSANPHAM like '%" + timkiemnd + "%' and IDDANHMUC=" + madanhmuc);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
            else if (Session["madanhmuc"] == null && Session["giatien"] != null)
            {
                String timkiemnd = Session["name"].ToString();
                Session["name"] = null;
                String giatien = Session["giatien"].ToString();
                Session["giatien"] = null;
                if (giatien == "1")
                {
                    DataTable dt = kn.laydata("select * from SANPHAM where TENSANPHAM like '%" + timkiemnd + "%' and DONGIA<=200000 and 100000<= DONGIA");
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
                else if (giatien == "2")
                {
                    DataTable dt = kn.laydata("select * from SANPHAM where TENSANPHAM like '%" + timkiemnd + "%' and DONGIA<=300000 and 200000<= DONGIA");
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
                else if (giatien == "3")
                {
                    DataTable dt = kn.laydata("select * from SANPHAM where TENSANPHAM like '%" + timkiemnd + "%' and DONGIA<=400000 and 300000<= DONGIA");
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
                else if (giatien == "4")
                {
                    DataTable dt = kn.laydata("select * from SANPHAM where TENSANPHAM like '%" + timkiemnd + "%' and DONGIA<=500000 and 400000<= DONGIA");
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
                else if (giatien == "5")
                {
                    DataTable dt = kn.laydata("select * from SANPHAM where TENSANPHAM like '%" + timkiemnd + "%' and 500000<= DONGIA");
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
            }
            else if (Session["madanhmuc"] != null && Session["giatien"] != null)
            {
                String timkiemnd = Session["name"].ToString();
                Session["name"] = null;
                String giatien = Session["giatien"].ToString();
                Session["giatien"] = null;
                String madanhmuc = Session["madanhmuc"].ToString();
                Session["madanhmuc"] = null;
                if (giatien == "1")
                {
                    DataTable dt = kn.laydata("select * from SANPHAM where TENSANPHAM like '%" + timkiemnd + "%' and DONGIA<=200000 and 100000<= DONGIA and IDDANHMUC=" + madanhmuc);
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
                else if (giatien == "2")
                {
                    DataTable dt = kn.laydata("select * from SANPHAM where TENSANPHAM like '%" + timkiemnd + "%' and DONGIA<=300000 and 200000<= DONGIA and IDDANHMUC=" + madanhmuc);
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
                else if (giatien == "3")
                {
                    DataTable dt = kn.laydata("select * from SANPHAM where TENSANPHAM like '%" + timkiemnd + "%' and DONGIA<=400000 and 300000<= DONGIA and IDDANHMUC=" + madanhmuc);
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
                else if (giatien == "4")
                {
                    DataTable dt = kn.laydata("select * from SANPHAM where TENSANPHAM like '%" + timkiemnd + "%' and DONGIA<=500000 and 400000<= DONGIA and IDDANHMUC=" + madanhmuc);
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
                else if (giatien == "5")
                {
                    DataTable dt = kn.laydata("select * from SANPHAM where TENSANPHAM like '%" + timkiemnd + "%' and 500000<= DONGIA and IDDANHMUC=" + madanhmuc);
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
            }
        }
    }
}