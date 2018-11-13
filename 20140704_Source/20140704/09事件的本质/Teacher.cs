using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09事件的本质
{
    class Teacher
    {
        public event Action _收作业;

        public void _打铃考试结束()
        {
            if (_收作业 != null)
            {
                _收作业();
            }
        }
    }
}
