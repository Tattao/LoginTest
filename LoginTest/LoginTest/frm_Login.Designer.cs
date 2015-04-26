namespace LoginTest
{
    partial class frm_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Close = new System.Windows.Forms.Button();
            this.chk_SavePwd = new System.Windows.Forms.CheckBox();
            this.txt_AccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AccountPwd = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.llbl_Register = new System.Windows.Forms.LinkLabel();
            this.llbl_RetrievePwd = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(307, 223);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "退出";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // chk_SavePwd
            // 
            this.chk_SavePwd.AutoSize = true;
            this.chk_SavePwd.Location = new System.Drawing.Point(201, 161);
            this.chk_SavePwd.Name = "chk_SavePwd";
            this.chk_SavePwd.Size = new System.Drawing.Size(72, 16);
            this.chk_SavePwd.TabIndex = 1;
            this.chk_SavePwd.Text = "保存密码";
            this.chk_SavePwd.UseVisualStyleBackColor = true;
            // 
            // txt_AccountName
            // 
            this.txt_AccountName.Location = new System.Drawing.Point(201, 70);
            this.txt_AccountName.Name = "txt_AccountName";
            this.txt_AccountName.Size = new System.Drawing.Size(156, 21);
            this.txt_AccountName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码";
            // 
            // txt_AccountPwd
            // 
            this.txt_AccountPwd.Location = new System.Drawing.Point(201, 113);
            this.txt_AccountPwd.Name = "txt_AccountPwd";
            this.txt_AccountPwd.Size = new System.Drawing.Size(156, 21);
            this.txt_AccountPwd.TabIndex = 5;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(107, 223);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // llbl_Register
            // 
            this.llbl_Register.AutoSize = true;
            this.llbl_Register.Location = new System.Drawing.Point(388, 70);
            this.llbl_Register.Name = "llbl_Register";
            this.llbl_Register.Size = new System.Drawing.Size(53, 12);
            this.llbl_Register.TabIndex = 7;
            this.llbl_Register.TabStop = true;
            this.llbl_Register.Text = "注册账号";
            this.llbl_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_Register_LinkClicked);
            // 
            // llbl_RetrievePwd
            // 
            this.llbl_RetrievePwd.AutoSize = true;
            this.llbl_RetrievePwd.Location = new System.Drawing.Point(304, 161);
            this.llbl_RetrievePwd.Name = "llbl_RetrievePwd";
            this.llbl_RetrievePwd.Size = new System.Drawing.Size(53, 12);
            this.llbl_RetrievePwd.TabIndex = 8;
            this.llbl_RetrievePwd.TabStop = true;
            this.llbl_RetrievePwd.Text = "忘记密码";
            this.llbl_RetrievePwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_RetrievePwd_LinkClicked);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(505, 299);
            this.ControlBox = false;
            this.Controls.Add(this.llbl_RetrievePwd);
            this.Controls.Add(this.llbl_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_AccountPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_AccountName);
            this.Controls.Add(this.chk_SavePwd);
            this.Controls.Add(this.btn_Close);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.CheckBox chk_SavePwd;
        private System.Windows.Forms.TextBox txt_AccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AccountPwd;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.LinkLabel llbl_Register;
        private System.Windows.Forms.LinkLabel llbl_RetrievePwd;
    }
}

