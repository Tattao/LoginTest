using LTBLL;
using LTModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginTest
{
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
        }

        private void frm_Register_Load(object sender, EventArgs e)
        {

        }

        private void btn_RegisterClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        public void btn_RegisterSave_Click(object sender, EventArgs e)
        {
            LT_Model n = new LT_Model();

            if (EmailCheck.CheckEmail(txt_RegisterEmail.Text.ToString()) == false)
            {
                lab_Email.Text = "✔";
            }  

            if(txt_RegisterName.TextLength==11)
            {
                lab_Name.Text = "✔";
            }
            else
            {
                lab_Name.Text = "请输入11位数字账号";
            }

            if (txt_RegisterPwd.TextLength >= 8)
            {
                lab_Password.Text = "✔";
                if (this.txt_RegisterPwd.Text == this.txt_RegisterConfirm.Text)
                {
                    lab_PwdConfirm.Text = "✔";
                    string FinalString = Security.SecurityMethod(n.AdminPwd.ToString());
                    n.EmailAddress = this.txt_RegisterEmail.Text.ToString().Trim();
                    n.AdminUser = this.txt_RegisterName.Text.ToString().Trim();
                    n.AdminPwd = FinalString.ToString().Trim();
                }
                else
                {
                    lab_PwdConfirm.Text = "请重新核对密码！";
                }
            }
            else
            {
                lab_Password.Text = "密码长度请输入8位及以上！";
            }
           

            if (LT_BLL.sysRegister(n)> 0)
            {
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("注册失败");
            }

            this.Close();
            frm_Login login = new frm_Login();
            login.Show();
        }
    }
}
