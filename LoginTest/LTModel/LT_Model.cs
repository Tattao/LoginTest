using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTModel
{
    public class LT_Model
    {
        private string adminUser = string.Empty;
        private string adminPwd = string.Empty;
        private string emailAddress = string.Empty;

        public string AdminUser
        {
            get { return adminUser; }
            set { adminUser = value; }
        }
        public string AdminPwd
        {
            get { return adminPwd; }
            set { adminPwd = value; }
        }
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
    }
}
