using System;
using System.Web.Security;

namespace RPS.library
{
    public class Cryptography
    {
        public static String MD5(String str)
        {
            str = str.Trim();
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToLower().Trim();
        }

        public static String SHA1(String str)
        {
            str = str.Trim();
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "SHA1").ToLower().Trim();
        }
    }
}