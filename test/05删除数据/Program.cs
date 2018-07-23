using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05删除数据
{
    class Program
    {
        static void Main(string[] args)
        {
            // 提示用户删除什么
            Console.WriteLine("请输入要删除的id号");
            string stuId = Console.ReadLine();
            // 开始删除
            // 连接字符串
            string connStr = "server=.;database=MyFirstDB;uid=sa;pwd=123;";
            // sql语句
            string sql = "delete from ConstraintExercise.StuInfo2 where stuId=" + stuId + ";";
            // 连接对象
            int count = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // 创建执行对象
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // 打开链接
                    conn.Open();
                    // 执行sql语句
                    count = cmd.ExecuteNonQuery();
                }
            }
            // 打印结果
            Console.WriteLine("{0}行受影响", count);
            Console.ReadKey();
        }
    }
}
