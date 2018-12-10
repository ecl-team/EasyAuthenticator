using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace authlib
{
    public class Authentication
    {
        public static bool Verify(string UserID, string Code)
        {
            if (Code == CurrentCode(UserID))
                return true;
            else
                return false;
        }

        public static string CurrentCode(string UserID)
        {
            long seconds = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
            string Key = UserID + (seconds - (seconds % 16));
            string hash = EHashing.Hash(Key);
            string Code = "";
            for (int i = 0; i < 8; i++)
            {
                Code += "" + long.Parse("" +
                    hash.ToCharArray()[8 * i] +
                    hash.ToCharArray()[8 * i + 1] +
                    hash.ToCharArray()[8 * i + 2] +
                    hash.ToCharArray()[8 * i + 3] +
                    hash.ToCharArray()[8 * i + 4] +
                    hash.ToCharArray()[8 * i + 5] +
                    hash.ToCharArray()[8 * i + 6] +
                    hash.ToCharArray()[8 * i + 7], System.Globalization.NumberStyles.HexNumber) % 10;
            }
            return Code;
        }
    }
}
