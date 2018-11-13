using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _12使用反射获得类型数据
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // 不适用Person这个类型的情况下调用这个方法
            // Person p = new Person();

            // 运算符 typeof
            Type t = typeof(Person);
            // Type tt = new Person().GetType();

            // Console.WriteLine(t.BaseType.BaseType.Name);

            // 1、获得Type类型的数据
            // 2、使用Activator.CreateInstance(Type)创建对象
            // 3、使用Type类型的Get系方法获得需要的数据(字段、属性、方法等)
            // 4、使用
            //  属性，利用属性对象.SetValue与GetValue获得该对象的数据
            //  方法，利用Invoke方法进行调用

            object o = Activator.CreateInstance(t);
            
            MethodInfo m = t.GetMethod("Say");

            FieldInfo f = t.GetField("Name");
            f.SetValue(o, "赵晓虎");

            // 对象.属性=值;
            // 设置属性的方法(对象, 值)


            m.Invoke(o, null);

            Console.ReadKey();
        }
    }
}
