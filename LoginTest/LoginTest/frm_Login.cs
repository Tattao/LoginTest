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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void llbl_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Register frm_register = new frm_Register();
            frm_register.Show();
            this.Hide();
        }

        private void llbl_RetrievePwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_RetrievePwd frm_retrievePwd = new frm_RetrievePwd();
            frm_retrievePwd.Show();
            this.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btn_Login_Click(object sender, EventArgs e)
        {
            LT_Model m = new LT_Model();
            string FinalString = Security.SecurityMethod(m.AdminPwd);
            m.AdminUser = this.txt_AccountName.Text.ToString();
            m.AdminPwd = FinalString.ToString();

            if (LT_BLL.sysLogin(m) > 0)
            {
                frm_test test = new frm_test();
                test.Show();
            }
            else
            {
                MessageBox.Show("登录失败，请重新输入密码！");
            }
        }

        private void chk_SavePwd_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
