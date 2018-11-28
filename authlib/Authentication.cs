using System;
using System.Collections.Generic;
using System.Linq;
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
            int seconds = Convert.ToInt32(DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local)).TotalSeconds);
            string Key = UserID + (seconds - (seconds % 16));
            ESHA256 hash = new ESHA256(Key);
            string Code = "";
            for (int i = 0; i < 8; i++)
            {
                Code += "" + long.Parse("" +
                    hash.Hash.ToCharArray()[8 * i] +
                    hash.Hash.ToCharArray()[8 * i + 1] +
                    hash.Hash.ToCharArray()[8 * i + 2] +
                    hash.Hash.ToCharArray()[8 * i + 3] +
                    hash.Hash.ToCharArray()[8 * i + 4] +
                    hash.Hash.ToCharArray()[8 * i + 5] +
                    hash.Hash.ToCharArray()[8 * i + 6] +
                    hash.Hash.ToCharArray()[8 * i + 7], System.Globalization.NumberStyles.HexNumber) % 10;
            }
            return Code;
        }

        public static string CurrentCode(string UserID, DateTime dt)
        {
            int seconds = Convert.ToInt32(dt.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local)).TotalSeconds);
            string Key = UserID + (seconds - (seconds % 16));
            ESHA256 hash = new ESHA256(Key);
            string Code = "";
            for (int i = 0; i < 8; i++)
            {
                Code += "" + long.Parse("" +
                    hash.Hash.ToCharArray()[8 * i] +
                    hash.Hash.ToCharArray()[8 * i + 1] +
                    hash.Hash.ToCharArray()[8 * i + 2] +
                    hash.Hash.ToCharArray()[8 * i + 3] +
                    hash.Hash.ToCharArray()[8 * i + 4] +
                    hash.Hash.ToCharArray()[8 * i + 5] +
                    hash.Hash.ToCharArray()[8 * i + 6] +
                    hash.Hash.ToCharArray()[8 * i + 7], System.Globalization.NumberStyles.HexNumber) % 10;
            }
            return Code;
        }
    }
}
