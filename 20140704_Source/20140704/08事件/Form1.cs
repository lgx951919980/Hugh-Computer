using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this._刘吉烨.Click += new EventHandler(_刘吉烨_Click);

            //this._刘吉烨.Click = (a,b)=>""; // 安全隐患1
        }

        void _刘吉烨_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("勒索朱海桥，请吃饭");
            //System.Diagnostics.Debug.WriteLine("控制台中输出");
            MessageBox.Show("勒索朱海桥，请吃饭");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 盗用_刘吉烨的点击事件
            //_刘吉烨.Click();
        }

       
    }

    class _朱海桥
    {
        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("哈哈，我把快递收了");
        }
    }
}
