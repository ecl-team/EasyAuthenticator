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
            int seconds = Convert.ToInt32(DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local)).TotalSeconds);
            string Key = UserID + (seconds - (seconds % 60));
            ESHA256 hash = new ESHA256(Key);
            string CodeCompare = "";
            for (int i = 0; i < 8; i++)
            {
                CodeCompare += "" + int.Parse("" + 
                    Key.ToCharArray()[8 * i] +
                    Key.ToCharArray()[8 * i + 1] +
                    Key.ToCharArray()[8 * i + 2] +
                    Key.ToCharArray()[8 * i + 3] +
                    Key.ToCharArray()[8 * i + 4] +
                    Key.ToCharArray()[8 * i + 5] +
                    Key.ToCharArray()[8 * i + 6] +
                    Key.ToCharArray()[8 * i + 7], System.Globalization.NumberStyles.HexNumber) % 10;
            }
            if (Code == CodeCompare)
                return true;
            else
                return false;
        }

        public static string Code(string UserID)
        {
            int seconds = Convert.ToInt32(DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local)).TotalSeconds);
            string Key = UserID + (seconds - (seconds % 60));
            ESHA256 hash = new ESHA256(Key);
            string Code = "";
            for (int i = 0; i < 8; i++)
            {
                Code += "" + int.Parse("" +
                    hash.Hash.ToCharArray()[8 * i] +
                    hash.Hash.ToCharArray()[8 * i + 1] +
                    hash.Hash.ToCharArray()[8 * i + 2] +
                    hash.Hash.ToCharArray()[8 * i + 3] +
                    hash.Hash.ToCharArray()[8 * i + 4] +
                    hash.Hash.ToCharArray()[8 * i + 5] +
                    hash.Hash.ToCharArray()[8 * i + 6] +
                    hash.Hash.ToCharArray()[8 * i + 7], System.Globalization.NumberStyles.HexNumber) % 10;
            }
            return Code.Replace("-", "");
        }
    }
}
