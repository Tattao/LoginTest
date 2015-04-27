using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTBLL
{
    public class EmailCheck
    {
        /// <summary> 
        /// 检测输入的邮件地址strEmail是否合法，非法则返回true。 
        /// </summary> 
        public static bool CheckEmail(string strEmail)
        {
            int i, j;
            string strTmp, strResult;
            string strWords = "abcdefghijklmnopqrstuvwxyz_-.0123456789"; //定义合法字符范围 
            bool blResult = false;
            strTmp = strEmail.Trim();
            //检测输入字符串是否为空，不为空时才执行代码。 
            if (!(strTmp == "" || strTmp.Length == 0))
            {
                //判断邮件地址中是否存在“@”号 
                if ((strTmp.IndexOf("@") < 0))
                {
                    blResult = true;
                    return blResult;
                }
                //以“@”号为分割符，把地址切分成两部分，分别进行验证。 
                string[] strChars = strTmp.Split(new char[] { '@' });
                foreach (string strChar in strChars)
                {
                    i = strChar.Length;
                    //“@”号前部分或后部分为空时。 
                    if (i == 0)
                    {
                        blResult = true;
                        return blResult;
                    }
                    //逐个字进行验证，如果超出所定义的字符范围strWords，则表示地址非法。 
                    for (j = 0; j < i; j++)
                    {
                        strResult = strChar.Substring(j, 1).ToLower();//逐个字符取出比较 
                        if (strWords.IndexOf(strResult) < 0)
                        {
                            blResult = true;
                            return blResult;
                        }
                    }
                }
            }
            return blResult;
        } 
    }
}
