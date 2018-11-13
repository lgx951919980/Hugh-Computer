using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace _01关于问题
{
    public delegate void FuncDelegate();

    class Program
    {
        #region MyRegion
        //int num = 10;


        //static void Main(string[] args)
        //{
        //    Program p = new Program();
        //    Func();
        //    int num = 10;

        //}


        //public static void Func()
        //{
        //    int num = 20;
        //} 
        #endregion

        #region MyRegion
        //static void Main(string[] args)
        //{
        //    string html = "http:\\/\\/www.123.com\\/123\\/456\\/abc.aspx?uid=123";

        //    // http:\/www.123.com

        //    html = Regex.Replace(html, @"\\", "");
        //} 
        #endregion

        #region MyRegion
        //static void Main(string[] args)
        //{
        //    // Func();
        //    FuncDelegate MyFun;

        //    MyFun = Func;

        //    MyFun();
        //}

        //public static void Func()
        //{
        //    Console.WriteLine("Func");
        //} 
        #endregion

        static void Main(string[] args)
        {
            // 班长.方法();

            // 刘吉烨.委托();

            _朱海乔 z = new _朱海乔();
            // z.Func();

            _刘吉烨 l = new _刘吉烨();
            l._委托 += z.Func;
            l._委托 += () => Console.WriteLine("帮助赵晓虎卖房子");
            // l._委托 = () => Console.WriteLine("刘岐收快递");

            // l._委托();

            // l._委托();

            

            

            l._触法委托存储的方法();

            Console.ReadKey();
        }
    }
}
