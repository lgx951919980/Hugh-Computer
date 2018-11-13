using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01lambda计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, string, int> expr = (num1, num2, jsf) =>
            //    {
            //        switch (jsf)
            //        {
            //            case "+": return num1 + num2;
            //            case "-": return num1 - num2;
            //            case "/": return num1 / num2;
            //            case "*": return num1 * num2;
            //            default:
            //                return 0;
            //        };

            //    };




            //while (true)
            //{
            //    Console.WriteLine("请输入第一个数字：");
            //    int n1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入第二个数字：");
            //    int n2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入操作符：");
            //    string jfs = Console.ReadLine();
            //    Console.WriteLine("{0}{1}{2}={3}", n1, jfs, n2, expr(n1, n2, jfs));

            //}



            List<string> list = new List<string>("可小,王洪林,黄健宇".Split(','));

            string query = "黄";
            var name = list/*.Where(c => c.Contains(query))*/.Select(c => "[" + c + "]");

            // 
            //List<TableColumn> list = ...
            //list.Select(e => {e.序号 = 值; return else;});

            // select * from name  where name like %"黄"%

            // Linq 林克
            // 语言集成查询
            // Where    筛选
            // Select   投影
            // IEnumerable<T>

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
