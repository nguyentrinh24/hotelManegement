using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hotelManegements
{
    public class connection
    {
        private static string _connectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\hotelManegements\hotelManegements\Database1.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
