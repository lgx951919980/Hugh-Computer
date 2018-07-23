using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09参数化查询
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 没有处理漏洞
            //Console.WriteLine("输入用户名");
            //string uid = Console.ReadLine();
            //Console.WriteLine("输入密码");
            //string pwd = Console.ReadLine();

            //// 登陆
            //string connStr = @"server=.;database=MyFirstDB;uid=sa;pwd=123;";
            //string sql =
            //        "select count(*) "
            //        + "from LoginTbl "
            //        + "where uid='" + uid + "' and pwd='" + pwd + "';";

            //int count = 0;
            //using (SqlConnection conn = new SqlConnection(connStr))
            //{
            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        conn.Open();
            //        count = (int)cmd.ExecuteScalar();
            //    }
            //}
            //Console.WriteLine(count);
            //Console.ReadKey(); 
            #endregion

            Console.WriteLine("输入用户名");
            string uid = Console.ReadLine();
            Console.WriteLine("输入密码");
            string pwd = Console.ReadLine();

            //  登陆
            string connStr = @"server=.;database=MyFirstDB;uid=sa;pwd=123;";
            string sql =
                    "select count(*) "
                    + "from LoginTbl "
                    + "where uid=@uid and pwd=@pwd;";

            SqlParameter pUid = new SqlParameter("@uid", uid);
            SqlParameter pPwd = new SqlParameter("@pwd", pwd);

            int count = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(pUid);
                    cmd.Parameters.Add(pPwd);

                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
