using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using LTModel;
using LTDAL;
using System.Security.Cryptography;

namespace LTBLL
{
    public class LT_BLL
    {
        /// <summary>
        /// 用户登录（BLL类）
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int sysLogin(LT_Model m)
        {
            string str = "select count(*) from logintest where adminUser='"+m.AdminUser+"' and adminPwd='"+m.AdminPwd+"'"; 
            OleDbParameter[] oleDbParameter ={
                                                 new OleDbParameter("adminUser",m.AdminUser),
                                                 new OleDbParameter("adminPwd",m.AdminPwd)
                                            };
            LT_DAL d = new LT_DAL();
            
            return Int32.Parse(d.ExecuteScalar(str,oleDbParameter));
        }

        public static int sysRegister(LT_Model n)
        {     
            string str2 = "insert into logintest(adminUser,adminPwd,EmailAddress) values(" + n.AdminUser + ",'" + n.AdminPwd + "','"+n.EmailAddress+"')";
            OleDbParameter[] oleDbParameter ={
                                                 new OleDbParameter("adminUser",n.AdminUser),
                                                 new OleDbParameter("adminPwd",n.AdminPwd),
                                                 new OleDbParameter("EmailAddress",n.EmailAddress)
                                            };
            LT_DAL d = new LT_DAL();
            string result = d.Register(str2, oleDbParameter);
            return Int32.Parse(result);
        }

        
    }
}
