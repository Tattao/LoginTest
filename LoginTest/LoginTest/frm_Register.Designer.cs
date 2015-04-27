namespace LoginTest
{
    partial class frm_Register
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
            this.btn_RegisterSave = new System.Windows.Forms.Button();
            this.txt_RegisterPwd = new System.Windows.Forms.TextBox();
            this.txt_RegisterName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RegisterEmail = new System.Windows.Forms.TextBox();
            this.btn_RegisterClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_RegisterConfirm = new System.Windows.Forms.TextBox();
            this.lab_Email = new System.Windows.Forms.Label();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_Password = new System.Windows.Forms.Label();
            this.lab_PwdConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_RegisterSave
            // 
            this.btn_RegisterSave.Location = new System.Drawing.Point(73, 245);
            this.btn_RegisterSave.Name = "btn_RegisterSave";
            this.btn_RegisterSave.Size = new System.Drawing.Size(75, 23);
            this.btn_RegisterSave.TabIndex = 15;
            this.btn_RegisterSave.Text = "保存";
            this.btn_RegisterSave.UseVisualStyleBackColor = true;
            this.btn_RegisterSave.Click += new System.EventHandler(this.btn_RegisterSave_Click);
            // 
            // txt_RegisterPwd
            // 
            this.txt_RegisterPwd.Location = new System.Drawing.Point(174, 146);
            this.txt_RegisterPwd.Name = "txt_RegisterPwd";
            this.txt_RegisterPwd.PasswordChar = '*';
            this.txt_RegisterPwd.Size = new System.Drawing.Size(175, 21);
            this.txt_RegisterPwd.TabIndex = 14;
            // 
            // txt_RegisterName
            // 
            this.txt_RegisterName.Location = new System.Drawing.Point(174, 103);
            this.txt_RegisterName.Name = "txt_RegisterName";
            this.txt_RegisterName.Size = new System.Drawing.Size(175, 21);
            this.txt_RegisterName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "密    码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "账    号";
            // 
            // txt_RegisterEmail
            // 
            this.txt_RegisterEmail.Location = new System.Drawing.Point(174, 63);
            this.txt_RegisterEmail.Name = "txt_RegisterEmail";
            this.txt_RegisterEmail.Size = new System.Drawing.Size(175, 21);
            this.txt_RegisterEmail.TabIndex = 10;
            // 
            // btn_RegisterClose
            // 
            this.btn_RegisterClose.Location = new System.Drawing.Point(284, 245);
            this.btn_RegisterClose.Name = "btn_RegisterClose";
            this.btn_RegisterClose.Size = new System.Drawing.Size(75, 23);
            this.btn_RegisterClose.TabIndex = 9;
            this.btn_RegisterClose.Text = "取消";
            this.btn_RegisterClose.UseVisualStyleBackColor = true;
            this.btn_RegisterClose.Click += new System.EventHandler(this.btn_RegisterClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "邮    箱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "确认密码";
            // 
            // txt_RegisterConfirm
            // 
            this.txt_RegisterConfirm.Location = new System.Drawing.Point(174, 188);
            this.txt_RegisterConfirm.Name = "txt_RegisterConfirm";
            this.txt_RegisterConfirm.PasswordChar = '*';
            this.txt_RegisterConfirm.Size = new System.Drawing.Size(175, 21);
            this.txt_RegisterConfirm.TabIndex = 17;
            // 
            // lab_Email
            // 
            this.lab_Email.AutoSize = true;
            this.lab_Email.Location = new System.Drawing.Point(355, 72);
            this.lab_Email.Name = "lab_Email";
            this.lab_Email.Size = new System.Drawing.Size(125, 12);
            this.lab_Email.TabIndex = 18;
            this.lab_Email.Text = "请输入正确邮箱地址！";
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(355, 112);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(125, 12);
            this.lab_Name.TabIndex = 19;
            this.lab_Name.Text = "请输入11位数字账号！";
            // 
            // lab_Password
            // 
            this.lab_Password.AutoSize = true;
            this.lab_Password.Location = new System.Drawing.Point(355, 149);
            this.lab_Password.Name = "lab_Password";
            this.lab_Password.Size = new System.Drawing.Size(77, 12);
            this.lab_Password.TabIndex = 20;
            this.lab_Password.Text = "请输入密码！";
            // 
            // lab_PwdConfirm
            // 
            this.lab_PwdConfirm.AutoSize = true;
            this.lab_PwdConfirm.Location = new System.Drawing.Point(355, 191);
            this.lab_PwdConfirm.Name = "lab_PwdConfirm";
            this.lab_PwdConfirm.Size = new System.Drawing.Size(101, 12);
            this.lab_PwdConfirm.TabIndex = 21;
            this.lab_PwdConfirm.Text = "请再次输入密码！";
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 298);
            this.Controls.Add(this.lab_PwdConfirm);
            this.Controls.Add(this.lab_Password);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.lab_Email);
            this.Controls.Add(this.txt_RegisterConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_RegisterSave);
            this.Controls.Add(this.txt_RegisterPwd);
            this.Controls.Add(this.txt_RegisterName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_RegisterEmail);
            this.Controls.Add(this.btn_RegisterClose);
            this.Controls.Add(this.label1);
            this.Name = "frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Register";
            this.Load += new System.EventHandler(this.frm_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RegisterSave;
        private System.Windows.Forms.TextBox txt_RegisterPwd;
        private System.Windows.Forms.TextBox txt_RegisterName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_RegisterEmail;
        private System.Windows.Forms.Button btn_RegisterClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_RegisterConfirm;
        private System.Windows.Forms.Label lab_Email;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_Password;
        private System.Windows.Forms.Label lab_PwdConfirm;
    }
}