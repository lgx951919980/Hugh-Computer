using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _11反射2;

namespace _11反射
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();

            Console.WriteLine(c1.Func() + 1);

            Console.ReadKey();
        }
    }
}
