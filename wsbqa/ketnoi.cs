using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace wsbqa
{
    
    public class ketnoi
    {
        SqlConnection con;
        private void layknoi()
        {
            //khởi tạo giá trị cho đối tượng SqlConnection 
            con = new SqlConnection(@"Data Source=NGUYEN_AN\SQLEXPRESS;Initial Catalog=CSDLDOAN4;Integrated Security=True");
            con.Open();//mở kết nối
        }
        //xay dựng hàm đóng kết nối
        private void dongketnoi()
        {
            if (con.State == ConnectionState.Open)//nếu kết nối đang mở
                con.Close();
        }
        public DataTable laydata(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                layknoi();//mở kết nối
                SqlDataAdapter adap = new SqlDataAdapter(sql, con);
                adap.Fill(dt);//đổ dữ liệu vào dt
            }
            catch
            {
                dt = null;
            }
            finally
            {
                dongketnoi();
            }
            return dt;//kết quả trả về là 1 DataTable
        }
        public int xuly(string sql)
        {
            int kq = 0;
            try
            {
                layknoi();
                SqlCommand cmd = new SqlCommand(sql, con);
                kq = cmd.ExecuteNonQuery();//thuc thi cau len khong can truy van
            }
            catch
            {
                kq = 0;
            }
            finally
            {
                dongketnoi();
            }
            return kq;
        }
        public void layketnoi()
        {
            con = new SqlConnection(@"Data Source=NGUYEN_AN\SQLEXPRESS;Initial Catalog=CSDLDoAnCN;Integrated Security=True");
        }
        //public void chuoiketnoi()
        //{
        //   chuoiketnoi = @"Data Source=NGUYEN_AN\SQLEXPRESS;Initial Catalog=CSDLDoAnCN;Integrated Security=True";
          
        //}
    }
   
}