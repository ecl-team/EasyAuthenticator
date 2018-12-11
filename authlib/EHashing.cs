using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace authlib
{
    public class EHashing
    {
        public static string Hash(string input)
        {
            SHA256 hash = SHA256.Create();
            byte[] bytes = hash.ComputeHash(Encoding.ASCII.GetBytes(input));
            string str = "";
            foreach (byte b in bytes)
                str += b.ToString("X2");
            return str;
        }
    }
}
