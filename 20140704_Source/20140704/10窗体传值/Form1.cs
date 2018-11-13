using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10窗体传值
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void ChangeColor()
        {
            this.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //i += 10;
            //    this.BackColor = Color.FromArgb(i, 256 - i, i);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 创建子窗体
            Form2 f = new Form2();

            // 订阅方法
            f.MyFunc += ChangeColor;

            f.Show();
        }
    }
}
