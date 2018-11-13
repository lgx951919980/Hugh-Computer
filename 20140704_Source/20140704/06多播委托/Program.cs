using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06多播委托
{
    public delegate int FuncHandler();
    class Program
    {
        static void Main(string[] args)
        {
            // multicast

            // 一个委托变量，存储多个方法，调用一次，多个方法依次执行
            // 委托链
            FuncHandler f;
            //f = Func1;
            // 多播委托的语法，使用+=追加方法，使用-=移除第一个找到的方法
            //f += Func2;
            //f += Func3;
            //f += Func2;
            //f += Func3;
            //f -= Func3;

            // 隐患
            f = Func4;
            f = f + Func3;
            f += Func2;
            f += Func1;

            // f.GetInvocationList();

            Console.WriteLine(f()) ;
            Console.ReadKey();
        }

        public static int Func1()
        {
            Console.WriteLine("Func1");
            return 1;
        }
        public static int Func2()
        {
            Console.WriteLine("Func2");
            return 2;
        }
        public static int Func3()
        {
            Console.WriteLine("Func3");
            return 3;
        }
        public static int Func4()
        {
            Console.WriteLine("Func4");
            return 4;
        }
    }
}
