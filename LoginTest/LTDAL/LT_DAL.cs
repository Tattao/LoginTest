using LTModel;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDAL
{
    public class LT_DAL
    {
        static String connstr = System.Configuration.ConfigurationManager.ConnectionStrings["LinkString"].ConnectionString;
        private static OleDbConnection con()
        {
            return new OleDbConnection(connstr);
        }

        public string ExecuteScalar(string str, System.Data.OleDb.OleDbParameter[] oleDbParameter)
        {
            OleDbConnection con = LT_DAL.con();          
            try
            {
                con.Open();
                OleDbCommand com = new OleDbCommand(str, con);
                com.Parameters.AddRange(oleDbParameter);
               return  Convert.ToString(com.ExecuteScalar());
            }
            catch(Exception Error)
            {
                throw Error;
            }
            finally
            {
                con.Close();
            }
        }

        public string Register(string str2, OleDbParameter[] oleDbParameter)
        {
            OleDbConnection con = LT_DAL.con();
            try
            {
                con.Open();
                OleDbCommand com = new OleDbCommand(str2, con);
                com.Parameters.AddRange(oleDbParameter);                
                return Convert.ToString(com.ExecuteNonQuery());               
            }
            catch (Exception Error)
            {
                throw Error;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
