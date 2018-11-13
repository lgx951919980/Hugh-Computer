using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 使用反射
{
    class Program
    {
        static void Main(string[] args)
        {
            // if(File.Exists(...))

            string path = "1.dll";
            Assembly asm = Assembly.LoadFile(Path.GetFullPath( path));
            // _1.Class1
            // Func
            // Type[] ts = asm.GetTypes(); 
            Type t = asm.GetType("_1.Class1");

            MethodInfo m = t.GetMethod("Func", BindingFlags.Instance | BindingFlags.NonPublic);

            int num = (int)m.Invoke(Activator.CreateInstance(t), new object[] { Console.ReadLine() });

            Console.WriteLine(num+1);
            Console.ReadKey();
        }
    }
}
