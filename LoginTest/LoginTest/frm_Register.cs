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
            this.Close();
        }

        public void btn_RegisterSave_Click(object sender, EventArgs e)
        {
            LT_Model n = new LT_Model();
            if (this.txt_RegisterPwd.Text == this.txt_RegisterConfirm.Text)
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] ByteString = System.Text.Encoding.ASCII.GetBytes(txt_RegisterPwd.Text);
                ByteString = md5.ComputeHash(ByteString);
                string FinalString = null;
                foreach (byte bt in ByteString)
                {
                    FinalString += bt.ToString("x2");
                }      
                n.AdminUser = this.txt_RegisterName.Text.ToString();
                n.AdminPwd = FinalString.ToString();
            }
            else
            {
                MessageBox.Show(" 请重新核对密码！");
            }

            if (LT_BLL.sysRegister(n)> 0)
            {
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }
    }
}
