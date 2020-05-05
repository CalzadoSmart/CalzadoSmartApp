using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Tools.Utileria
{
    public class CadenaMD5
    {
        public static String cadenaToMD5(String cadena)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] hash;
            byte[] value;

            value = System.Text.Encoding.UTF8.GetBytes(cadena);

            hash = md5.ComputeHash(value);
            md5.Clear();

            StringBuilder str = new StringBuilder();
            for (int i = 0; i <= hash.Length - 1; i++)
            {
                str.Append(hash[i].ToString("x").PadLeft(2, Convert.ToChar("0")));
            }

            return str.ToString();
        }
    }
}
