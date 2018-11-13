using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05利用Lambda实现集合的查找
{
    public delegate bool SeachHandler(string s);

    class Program
    {
        static void Main(string[] args)
        {
            // 扩展方法与集合查找
            List<string> list = new List<string>("赵晓虎,王小虎,乐虎,老虎,东北虎,华南虎".Split(','));
            List<string> res;
            #region MyRegion
            //// 找出名字中有“北”的
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i].Contains("北"))
            //    {
            //        res.Add(list[i]);
            //    }
            //}

            //// 找出名字中包含“北”或“华”的
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i].Contains("北") || list[i].Contains("华"))
            //    {
            //        res.Add(list[i]);
            //    }
            //} 
            #endregion


            // res = ListExt.JKWhere(list, e => e.Contains("晓"));
            res = list.JKWhere(e => Regex.IsMatch(e, "北|南"));
            
            // list.j

        }

        
    }
}
