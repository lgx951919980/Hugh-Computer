using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05利用Lambda实现集合的查找
{
    public static class ListExt
    {
        public static List<string> JKWhere(this List<string> list, SeachHandler f)
        {
            List<string> res = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (f(list[i]))
                {
                    res.Add(list[i]);
                }
            }
            return res;
        }
    }
}
