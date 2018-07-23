using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07登陆验证
{
    class JKConsole
    {
        public static string ReadPassword()
        {
            string str = "";
            while (true)
            {
                ConsoleKeyInfo temp = Console.ReadKey(true);

                if (temp.KeyChar == '\r')
                {
                    break;
                }
                if (temp.KeyChar == '\b' && str.Length == 0)
                {
                    continue;
                }
                if (temp.KeyChar == '\b')
                {
                    Console.Write("\b \b");
                    str = str.Substring(0, str.Length - 1);
                }
                else
                {
                    str += temp.KeyChar.ToString().Trim();
                    Console.Write("*");
                }
            }
            return str;
        }
    }
}
