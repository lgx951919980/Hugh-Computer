using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04连接池的性能对比
{
    class Program
    {
        static void Main(string[] args)
        {
            // 比较连接池
            SqlConnection conn;
            string connStr = @"server=.;database=master;uid=sa;pwd=123;";

            Stopwatch sp = new Stopwatch();
            sp.Start();
            for (int i = 0; i < 99; i++)
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                // conn.Dispose();
            }

            sp.Stop();
            Console.WriteLine(sp.Elapsed);
            Console.ReadKey();
        }
    }
}
