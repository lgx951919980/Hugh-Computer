using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07系统自带的泛型委托
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func<T...>
            // Action
            // Action<T...>

            //Action<int> func = e => Console.WriteLine(e);

            //func(123);

            // Action<

            Func<int> f = () => 123;
            
            Console.WriteLine(f() + 1);

            List<string> list = new List<string>("赵晓虎,王小虎,乐虎,老虎,东北虎,华南虎".Split(','));

            foreach (string item in list.Where(e => e.Contains("华")))
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
