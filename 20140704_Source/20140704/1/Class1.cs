using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Class1
    {
        private int Func(string num)
        {
            int n;
            if (int.TryParse(num, out n))
            {
                return n;
            }
            return 0;
        }
        public void Func()
        {
            Console.WriteLine("无参方法");
        }
    }
}
