using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authlib
{
    public class EBase64
    {
        private static Random r = new Random();

        public static string Generate(int Length)
        {
            string Token = "";
            for (int i = 0; i < Length; i++)
            {
                switch (r.Next(0, 64))
                {
                    case 0: Token += "0"; break;
                    case 1: Token += "1"; break;
                    case 2: Token += "2"; break;
                    case 3: Token += "3"; break;
                    case 4: Token += "4"; break;
                    case 5: Token += "5"; break;
                    case 6: Token += "6"; break;
                    case 7: Token += "7"; break;
                    case 8: Token += "8"; break;
                    case 9: Token += "9"; break;
                    case 10: Token += "a"; break;
                    case 11: Token += "b"; break;
                    case 12: Token += "c"; break;
                    case 13: Token += "d"; break;
                    case 14: Token += "e"; break;
                    case 15: Token += "f"; break;
                    case 16: Token += "g"; break;
                    case 17: Token += "h"; break;
                    case 18: Token += "i"; break;
                    case 19: Token += "j"; break;
                    case 20: Token += "k"; break;
                    case 21: Token += "l"; break;
                    case 22: Token += "m"; break;
                    case 23: Token += "n"; break;
                    case 24: Token += "o"; break;
                    case 25: Token += "p"; break;
                    case 26: Token += "q"; break;
                    case 27: Token += "r"; break;
                    case 28: Token += "s"; break;
                    case 29: Token += "t"; break;
                    case 30: Token += "u"; break;
                    case 31: Token += "v"; break;
                    case 32: Token += "w"; break;
                    case 33: Token += "x"; break;
                    case 34: Token += "y"; break;
                    case 35: Token += "z"; break;
                    case 36: Token += "A"; break;
                    case 37: Token += "B"; break;
                    case 38: Token += "C"; break;
                    case 39: Token += "D"; break;
                    case 40: Token += "E"; break;
                    case 41: Token += "F"; break;
                    case 42: Token += "G"; break;
                    case 43: Token += "H"; break;
                    case 44: Token += "I"; break;
                    case 45: Token += "J"; break;
                    case 46: Token += "K"; break;
                    case 47: Token += "L"; break;
                    case 48: Token += "M"; break;
                    case 49: Token += "N"; break;
                    case 50: Token += "O"; break;
                    case 51: Token += "P"; break;
                    case 52: Token += "Q"; break;
                    case 53: Token += "R"; break;
                    case 54: Token += "S"; break;
                    case 55: Token += "T"; break;
                    case 56: Token += "U"; break;
                    case 57: Token += "V"; break;
                    case 58: Token += "W"; break;
                    case 59: Token += "X"; break;
                    case 60: Token += "Y"; break;
                    case 61: Token += "Z"; break;
                    case 62: Token += "-"; break;
                    case 63: Token += "_"; break;
                }
            }
            return Token;
        }
    }
}
