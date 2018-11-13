using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03委托计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            // 需要什么？
            // 委托
            // 实现加减乘除的方法

            Console.WriteLine("请输入数字");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入运算符");
            string oper = Console.ReadLine();
            Console.WriteLine("请输入数字");
            int num2 = Convert.ToInt32(Console.ReadLine());

            MyCalculator cal = null;

            switch (oper)
            {
                case "+": cal = Calculator.AdditionMethod; break;
                case "-": cal = Calculator.SubtractionMethod; break;
                case "*": cal = Calculator.MultiplicationMethod; break;
                case "/": cal = Calculator.DivisionMethod; break;
            }

            if (cal != null)
            {
                Console.WriteLine("{0}{1}{2}={3}", num1, oper, num2, cal(num1, num2));
            }

            Console.ReadKey();
        }
    }
}
