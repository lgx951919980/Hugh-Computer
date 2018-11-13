using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01关于问题
{
    class _刘吉烨
    {
        // 事件只是一个语法的名字，就是在类中定义一个委托类型的字段，然后再将其设置为event
        // 那么这个语法只允许在类型的内部进行方法调用
        // 在外界只允许使用+=和-=的操作
        public event FuncDelegate _委托;

        public void _触法委托存储的方法()
        {
            if (_委托 != null)
            {
                _委托();
            }
        }
    }
}
