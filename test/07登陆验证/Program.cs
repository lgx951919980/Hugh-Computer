using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07登陆验证
{
    class Program
    {
        static void Main(string[] args)
        {
            // 提示用户输入用户名
            Console.Write("Enter User Id:");
            string uid = Console.ReadLine();
            // 提示用户输入密码
            Console.Write("Enter Password:");
            string pwd = JKConsole.ReadPassword();

            // 验证用户登录与否
            // 连接字符串
            // sql语句
            // 连接对象
            // 执行对象
            // 打开
            // 执行
            // 的结果
            string connStr = @"server=.;database=MyFirstDB;uid=sa;pwd=123;";
            string sql = string.Format("select count(*) from LoginTbl where uid='{0}' and pwd='{1}';", uid, pwd);
            int count = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                }
            }
            if (count > 0)
            {
                Console.WriteLine();
                Console.Write(msg);
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("Error.....");
            }

            Console.ReadKey();
        }


        static string msg = @"Welcome to the MySQL monitor.  Commands end with ; or \g.
Your MySQL connection id is 5
Server version: 5.6.19-log MySQL Community Server (GPL)

Copyright (c) 2000, 2014, Oracle and/or its affiliates. All rights reserved.

Oracle is a registered trademark of Oracle Corporation and/or its
affiliates. Other names may be trademarks of their respective
owners.

Type 'help;' or '\h' for help. Type '\c' to clear the current input statement.

mysql>";
    }
}
