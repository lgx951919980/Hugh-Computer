using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04匿名方法
{
    public delegate void FuncHandler();
    public delegate int FuncReturnIntHandler();
    public delegate int SumHandler(int n1, int n2);
    class Program
    {
        static void Main(string[] args)
        {
            //FuncHandler f = Fn;

            //f();

            // 
            //string s = "123";
            //string ss = new string(new char[] { '1', '2', '3' });

            
            //FuncHandler f = delegate()
            //{
            //    Console.WriteLine("我是匿名方法");
            //};

            //f();

            //FuncReturnIntHandler f = delegate() {
            //    return 1;
            //};
            //Console.WriteLine(f() + 1);

            //SumHandler sum = delegate(int num1, int num2)
            //{
            //    return num1 + num2;
            //};

            SumHandler sum = (n1, n2) => n1 + n2;
            // Lambda表达式，是对匿名方法的进一步简化

            Console.ReadKey();
        }

        //public static void Fn()
        //{
        //    Console.WriteLine("我是静态方法Fn");
        //}
    }

}
