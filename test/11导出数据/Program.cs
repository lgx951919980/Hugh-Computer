using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11导出数据
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            string sql = "select * from TestDatabase..student;";
            string connStr = "server=.;database=MyFirstDB;uid=sa;pwd=123;";
            StreamWriter writer = new StreamWriter("studnet.csv", true, Encoding.Default);
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //List<string> list = new List<string>();
                        // 千万不要使用TestDatabase这个数据库测试
                        while (reader.Read())
                        {
                            // reader[i]
                            // FieldCount
                            List<string> list = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                list.Add(reader[i].ToString());
                            }
                            writer.WriteLine(string.Join(",", list));
                        }
                    }
                }
            }

            writer.Dispose();
        }
    }
}
