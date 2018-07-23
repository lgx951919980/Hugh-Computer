using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06修改数据
{
    class Program
    {
        static void Main(string[] args)
        {
            // 修改第几条数据，修改什么字段为什么值
            Console.WriteLine("请输入要修改的数据编号(stuId)");
            string stuId = Console.ReadLine().Trim();
            Console.WriteLine("是否要修改姓名，如果需要修改请出入，否则直接回车");
            string stuName = Console.ReadLine().Trim();
            Console.WriteLine("是否要修改年龄，如果需要修改请出入，否则直接回车");
            string stuAge = Console.ReadLine().Trim();
            Console.WriteLine("是否要修改性别，如果需要修改请出入，否则直接回车");
            string stuSex = Console.ReadLine().Trim();

            // 生成SQL语句
            // upate tbl set stuName='赵晓虎', stuAge=123, stuSex='f' where stuId=1;
            List<string> list = new List<string>();
            if (stuName.Length != 0)
            {
                // stuName=' + stuName + '
                list.Add("stuName='" + stuName + "'");
            }
            if (stuAge.Length != 0)
            {
                list.Add(string.Format("stuAge={0}", stuAge));
            }
            if (stuSex.Length != 0)
            {
                list.Add(string.Format("stuSex='{0}'", stuSex));
            }

            string sql = "update MyFirstDB.ConstraintExercise.StuInfo2 set " +
                   string.Join(",", list)
                   + " where stuId=" + stuId;


            // 连接字符串
            string connStr = @"server=.;database=MyFirstDB;uid=sa;pwd=123;";
            // 创建连接对象
            int count = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            { 
                // 创建执行对象
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                { 
                    // 打开连接
                    conn.Open();
                    // 执行
                    count = cmd.ExecuteNonQuery();
                }
            }

            Console.WriteLine("{0} 行受影响", count);
            Console.ReadKey();
        }
    }
}
