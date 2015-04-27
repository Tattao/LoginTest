using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LTBLL
{
    public class Security
    {
        public static string SecurityMethod(string TextValue)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] ByteString = System.Text.Encoding.ASCII.GetBytes(TextValue);
            ByteString = md5.ComputeHash(ByteString);
            string FinalString = null;
            foreach (byte bt in ByteString)
            {
                FinalString += bt.ToString("x2");
            }
            return FinalString.ToString();
        }
    }
}
