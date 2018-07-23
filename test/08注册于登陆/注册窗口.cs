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
    public partial class 注册窗口 : Form
    {
        public 注册窗口()
        {
            InitializeComponent();
        }

        private void txtUid_Leave(object sender, EventArgs e)
        {
            // 鼠标离开的时候验证用户名是否存在
            string uid = txtUid.Text.Trim();
            if (uid.Length == 0) return;

            // 不为空的时候验证
            // sql
            string sql = "select count(*) from LoginTbl where uid='" + uid + "'";
            int count = (int)SQLHelper.ExecuteScalar(sql);

            if (count > 0)
            {
                // 已被注册不允许使用
                lbMsg.ForeColor = Color.Red;
                lbMsg.Text = "该用户已经注册，请重新输入用户名";
            }
            else
            {
                lbMsg.ForeColor = Color.Green;
                lbMsg.Text = "√";
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            // 验证
            string uid = txtUid.Text.Trim();
            string pwd1 = txtPwd1.Text;
            string pwd2 = txtPwd2.Text;

            // 空
            if (uid.Length == 0 || pwd1.Length == 0 || pwd2.Length == 0)
            {
                return;
            }
            // 两次密码必须相同
            if (pwd1 != pwd2) return;

            // 用户名是否可用
            if (lbMsg.Text != "√") return;

            // 。。。
            // sql
            string sql = "insert into LoginTbl(uid, pwd) values('" + uid + "', '" + pwd1 + "')";
            int count = SQLHelper.ExecuteNonQuery(sql);

            if (count > 0)
            {
                MessageBox.Show("注册成功");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
