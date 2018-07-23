using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08注册于登陆
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point pStart;

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            // 只有在左键按下的时候才允许移动
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            { 
                // 设置窗体的坐标即可
                //this.Location.X = e.X - pStart.X + this.Location.X;
                //this.Location.Y = e.Y - pStart.Y + this.Location.Y;

                this.Location = new Point(
                         e.X - pStart.X + this.Location.X,
                         e.Y - pStart.Y + this.Location.Y
                    );
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            pStart = new Point(e.X, e.Y);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.Trim();
            string pwd = txtPwd.Text.Replace("'", "''");

            if (uid.Length == 0 || pwd.Length == 0)
            {
                MessageBox.Show("请输入完整信息");
                return;
            }

            string connStr = @"server=.;database=MyFirstDB;uid=sa;pwd=123;";
            string sql = string.Format("select count(*) from LoginTbl where uid='{0}' and pwd='{1}';", uid, pwd);
            int count = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                }
            }
            if (count > 0)
            {
                MessageBox.Show("登陆成功");
            }
            else
            {
                MessageBox.Show("登陆失败");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // 注册
            注册窗口 zc = new 注册窗口();

            zc.Show();
        }
    }
}
