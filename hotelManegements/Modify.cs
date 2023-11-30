using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hotelManegements
{
    public class Modify
    {
        public Modify() { }
        SqlCommand command;// dung de truy van 
        SqlDataReader reader;// doc du lieu trong db


        public List<taiKhoan> taiKhoans(string query)
        {
            List<taiKhoan> account = new List<taiKhoan>();
            using (SqlConnection conn = connection.GetSqlConnection())
            {
                conn.Open();
                command= new SqlCommand(query,conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    account.Add(new taiKhoan(reader.GetString(0),reader.GetString(1)));
                }

                conn.Close();
            }

            return account;
        }
        public void commands (string query)
        {
            using (SqlConnection conn = connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query,conn);
                command.ExecuteNonQuery();// thuc thi truy van 
                conn.Close();
            }
        }
    }
}
