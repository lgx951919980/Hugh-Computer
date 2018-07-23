using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08注册于登陆
{
    class SQLHelper
    {
        static string connStr = @"server=.;database=MyFirstDB;uid=sa;pwd=123;";

        public static int ExecuteNonQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static object ExecuteScalar(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
