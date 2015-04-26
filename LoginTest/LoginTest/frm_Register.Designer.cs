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
            // 
            // txt_RegisterPwd
            // 
            this.txt_RegisterPwd.Location = new System.Drawing.Point(174, 146);
            this.txt_RegisterPwd.Name = "txt_RegisterPwd";
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
            this.label4.Location = new System.Drawing.Point(95, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "确认密码";
            // 
            // txt_RegisterConfirm
            // 
            this.txt_RegisterConfirm.Location = new System.Drawing.Point(174, 194);
            this.txt_RegisterConfirm.Name = "txt_RegisterConfirm";
            this.txt_RegisterConfirm.Size = new System.Drawing.Size(175, 21);
            this.txt_RegisterConfirm.TabIndex = 17;
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 298);
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
    }
}