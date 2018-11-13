using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02委托变量作为参数使用
{
    public delegate int MyCompareHandler(Person p1, Person p2);

    public class Program
    {
        static void Main(string[] args)
        {
            MyCompareHandler MyCompare = null;
            Person[] ps = 
            {
                new Person() { Age=10, Name="赵晓虎", Sex='男' },
                new Person() { Age=30, Name="波波", Sex='男' },
                new Person() { Age=35, Name="杨茜", Sex='女' },
                new Person() { Age=13, Name="马伦", Sex='男' }
            };
            // 排序
            // 比较
            // int n = string.Compare("a", "b");
            // MyCompare = CompareByAge;
            //MyCompare = CompareByName;

            //if (MyCompare != null)
            //{
            //    int num = MyCompare(ps[0], ps[1]);
            //}

            // MyCompareHandler compare = CompareByAge;

            // Sort(ps, compare);

            // Sort(ps, CompareByName);

            Sort(ps, (a, b) => string.Compare(a.Name, b.Name));
            Sort(ps, (a, b) => a.Age - b.Age);
        }

        public static void Sort(Person[] ps, MyCompareHandler compare)
        {
            if (compare == null) return;
            for (int i = 0; i < ps.Length - 1; i++)
            {
                for (int j = 0; j < ps.Length - i - 1; j++)
                {
                    if (compare(ps[j], ps[j + 1]) > 0)
                    {
                        Person pTemp = ps[j];
                        ps[j] = ps[j + 1];
                        ps[j + 1] = pTemp;
                    }
                }
            }
        }

        //public static int CompareByAge(Person p1, Person p2)
        //{
        //    // n1 > n2 => n1 - n2 > 0
        //    return p1.Age - p2.Age;
        //}
        //public static int CompareByName(Person p1, Person p2)
        //{
        //    return string.Compare(p1.Name, p2.Name);
        //}
    }
}
