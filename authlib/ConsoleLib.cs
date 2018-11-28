using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authlib
{
    public class ConsoleLib
    {
        public static void Write(string Text, ConsoleColor Color)
        {
            ConsoleColor p = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.Write(Text);
            Console.ForegroundColor = p;
        }

        public static void WriteLine(string Text, ConsoleColor Color)
        {
            ConsoleColor p = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(Text);
            Console.ForegroundColor = p;
        }
    }
}
