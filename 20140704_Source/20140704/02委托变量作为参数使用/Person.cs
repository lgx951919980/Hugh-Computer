using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02委托变量作为参数使用
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1}", Name, Age);
        }
    }
}
