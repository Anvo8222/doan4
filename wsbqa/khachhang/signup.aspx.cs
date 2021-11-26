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
    public partial class signup : System.Web.UI.Page
    {
        static string code;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTiepTuc_Click(object sender, EventArgs e)
        {
            //tiep tuc
            string con = Session["con"].ToString();
            SqlConnection conn = new SqlConnection(con);
            //random mã code
            Random random = new Random();
            code = random.Next(1000, 9999).ToString();
            //kiểm tra có tồn tại email và tên đăng nhập hay không
            string email = txtEmail.Text;
            string matkhaudk = txtPassword1.Text;
            string matkhaudkAG = txtPassword2.Text;
            string kiemtraemail = ("select EMAIL from TAIKHOAN  WHERE EMAIL='" + email + "'");
            DataTable table1 = new DataTable();
            try
            {
                SqlDataAdapter da1 = new SqlDataAdapter(kiemtraemail, conn);
                da1.Fill(table1);

            }
            catch (SqlException err)
            {
                Response.Write("<p><b>Error: </b>" + err.Message + "</p>");
            }

            if (matkhaudk == matkhaudkAG)
            {
                if (table1.Rows.Count == 0)
                {
                    //chưa tồn tại trong csdl      
                    Session["matkhau"] = matkhaudk;
                    Session["email"] = email;
                    Session["code"] = code;
                    sendcode();
                    Response.Redirect("XacNhanMatKhau.aspx");

                }
                else if (table1.Rows.Count != 0)
                {
                    Response.Write("<script>alert('Email đã được sử dụng, vui lòng nhập lại!');</script>");
                    txtEmail.Text = "";
                }

            }
            else
            {
                Response.Write("<script>alert('Mật khẩu không khớp, vui lòng nhập lại!');</script>");
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