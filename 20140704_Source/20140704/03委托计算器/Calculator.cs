using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03委托计算器
{
    public class Calculator
    {
        public static int AdditionMethod(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int SubtractionMethod(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int MultiplicationMethod(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int DivisionMethod(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
