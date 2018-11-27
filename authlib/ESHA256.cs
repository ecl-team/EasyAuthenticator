using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace authlib
{
    public class ESHA256
    {
        private string _Hash;

        public ESHA256(string Input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                _Hash = builder.ToString();
            }
        }

        public string Hash
        {
            get
            {
                return _Hash;
            }
        }
    }
}
