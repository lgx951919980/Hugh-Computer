using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02连接数据库
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection();
            // 创建这个对象，不代表就立即连接
            // 提供连接使用的参数
            conn.ConnectionString = @"server=.;database=MyFirstDB;uid=sa;pwd=123;";

            // 打开连接
            conn.Open();

            Console.WriteLine("OK");
            // 连接使用数据库以后，要关闭连接，释放链接对象
            conn.Close();
            conn.Dispose(); // 释放后才允许被CLR进行管理

            Console.ReadKey();
        }
    }
}
