using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03执行增删改的模型ExecuteNonQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = @"server=.;database=MyFirstDB;uid=sa;pwd=123;";
            string sql = "insert into MyFirstDB.ConstraintExercise.StuInfo2(stuId, stuName, stuAge, stuSex) values(4, '马伦', 25, 'm');";
            using (SqlConnection conn = new SqlConnection(connStr))
            { 
                // 创建执行对象
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sql;

                    // 尽可能晚打开数据库，并且尽可能早的关闭数据库
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();

                    Console.WriteLine("{0} 行受影响", count);
                }
            }
            Console.ReadKey();
        }
    }
}
