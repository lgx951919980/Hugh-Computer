namespace _08注册于登陆
{
    partial class 注册窗口
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.lbMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(124, 32);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(139, 21);
            this.txtUid.TabIndex = 1;
            this.txtUid.Leave += new System.EventHandler(this.txtUid_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码";
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(124, 86);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.Size = new System.Drawing.Size(139, 21);
            this.txtPwd1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "确认密码";
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(124, 128);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.Size = new System.Drawing.Size(139, 21);
            this.txtPwd2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(55, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(188, 186);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "注册";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(124, 60);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(0, 12);
            this.lbMsg.TabIndex = 3;
            // 
            // 注册窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 306);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPwd2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPwd1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.label1);
            this.Name = "注册窗口";
            this.Text = "注册窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPwd1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lbMsg;
    }
}