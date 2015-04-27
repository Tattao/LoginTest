using LTDAL;
using LTModel;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTBLL
{
    public class RetrievePwd
    {
        public static int RetrievePassword(LT_Model r)
        {
            string str3 = "select count(*) from logintest where adminUser='" + r.AdminUser + "'";
            OleDbParameter[] oleDbParameter = { new OleDbParameter("adminUser",r.AdminUser)};
            LT_DAL d = new LT_DAL();
            return Int32.Parse(d.ExecuteScalar(str3,oleDbParameter));
        }
    }
}
