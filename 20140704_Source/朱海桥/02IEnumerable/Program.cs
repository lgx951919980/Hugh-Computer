using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("赵晓虎", "是纸老虎，俗称Tiger赵");
            dic.Add("马伦", "是老马，常常成为ml");
            dic.Add("牛亮亮", "是老牛，只差一步就是null");

            Dictionary<string, string>.Enumerator em = dic.GetEnumerator();
            //for (int i = 0; em.MoveNext(); i++)
            //{
            //    KeyValuePair<string, string> kv = em.Current;
            //    // 这个kv就是迭代遍历，foreach中的item
            //    Console.WriteLine(kv.Key + "," + kv.Value);

            //}

            foreach (var item in dic)
            {

            }

            Console.ReadKey();
        }
    }
}
