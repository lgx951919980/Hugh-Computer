using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09事件的本质
{
    class Student
    {
        public string Name { get; set; }
        public void _交试卷()
        {
            Console.WriteLine("{0},把试卷上交了", Name);
        }
    }
}
