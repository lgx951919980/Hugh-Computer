using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12使用反射获得类型数据
{
    class Person
    {
        public string Name;
        public void Say()
        {
            Console.WriteLine("Hello, {0}是一个方法", Name);
        }
    }
}
