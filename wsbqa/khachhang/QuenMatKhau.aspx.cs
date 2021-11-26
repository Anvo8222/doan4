using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace wsbqa.khachhang
{
    public partial class QuenMatKhau : System.Web.UI.Page
    {
        static string code;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            string con = Session["con"].ToString();
            SqlConnection conn = new SqlConnection(con);
            Random random = new Random();
            code = random.Next(1000, 9999).ToString();
            string email = txtEmail.Text;
            string kiemtradk = ("select EMAIL from TAIKHOAN WHERE EMAIL='" + email + "'");
            DataTable table1 = new DataTable();
            try
            {
                SqlDataAdapter da1 = new SqlDataAdapter(kiemtradk, conn);
                da1.Fill(table1);
            }
            catch (SqlException err)
            {
                Response.Write("<p><b>Error: </b>" + err.Message + "</p>");
            }
            if (table1.Rows.Count != 0)
            {
                // tồn tại trong csdl 
                Session["emailquenmk"] = email;
                Session["codeQuenMK"] = code;
                sendcode();
                Response.Redirect("XacNhanQuenMK.aspx");

            }
            else if (table1.Rows.Count == 0)
            {
                Response.Write("<script>alert('Không tìm thấy tài khoản');</script>");
            }
        }
        private void sendcode()
        {
            string fromaddr = "anvo8222@gmail.com";
            string toaddr = txtEmail.Text;//TO ADDRESS HERE
            string password = "ukqnblhwzzsgrkpz";
            MailMessage msg = new MailMessage();
            msg.Subject = "Mã kích hoạt để xác minh địa chỉ Email!";
            msg.From = new MailAddress(fromaddr);
            msg.Body = "Mã xác nhận của bạn là: " + code;
            msg.To.Add(new MailAddress(txtEmail.Text));
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            NetworkCredential nc = new NetworkCredential(fromaddr, password);
            smtp.Credentials = nc;
            smtp.Send(msg);
        }
    }
}