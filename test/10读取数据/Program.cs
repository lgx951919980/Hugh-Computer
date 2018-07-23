using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10读取数据
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql = "select * from LoginTbl;";

            string connStr = @"server=.;database=MyFirstDB;uid=sa;pwd=123;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    // 调用方法
                    SqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        //bool isTrue = reader.Read();
                        //reader[
                        //isTrue = reader.Read();
                        //isTrue = reader.Read();
                        //isTrue = reader.Read();
                        //isTrue = reader.Read();

                        while (reader.Read())
                        {
                            Console.WriteLine("{0},{1},{2}",
                                reader[0],
                                reader[1],
                                reader[2]);
                            
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
