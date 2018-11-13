using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09事件的本质
{
    class Program
    {
        static void Main(string[] args)
        {
            // 时间的本质
            // 事件的实现必须要有
            // 1、一个委托的类型
            // 2、有一个类
            // 3、这个类型中有一个"委托类型的变量"(加上event的委托变量)
            // 4、触法事件的方法

            // 事件过程的概念
            // 一个事件触发需要经历几个步骤？
            // 要有事件源，触法者，干了什么事儿
            // 要有相应，一旦触发就会调用某一个方法
            // 触法事件方法，判断事件变量是否为空，如果不为空就调用方法


            Teacher tch = new Teacher();
            Student s1 = new Student() { Name = "赵晓虎" };
            Student s2 = new Student() { Name = "马伦" };
            Student s3 = new Student() { Name = "刘岐" };
            Student s4 = new Student() { Name = "王成伟" };


            // 绑定方法的功能
            tch._收作业 += s1._交试卷;

            tch._收作业 += s2._交试卷;
            tch._收作业 += s3._交试卷;
            tch._收作业 += s4._交试卷;


            tch._打铃考试结束();

            Console.ReadKey();
        }
    }
}
