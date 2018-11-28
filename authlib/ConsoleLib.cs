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

        public static void WriteColor(string Text)
        {
            ConsoleColor p = Console.ForegroundColor;
            string[] Segments = Text.Split('&');
            Console.Write(Segments[0]);
            for (int i = 1; i < Segments.Length; i++)
            {
                bool Color = true;
                switch (Segments[i].ToLower().ToCharArray()[0])
                {
                    case '0': Console.ForegroundColor = ConsoleColor.Black; break;
                    case '1': Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                    case '2': Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                    case '3': Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                    case '4': Console.ForegroundColor = ConsoleColor.DarkRed; break;
                    case '5': Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                    case '6': Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                    case '7': Console.ForegroundColor = ConsoleColor.Gray; break;
                    case '8': Console.ForegroundColor = ConsoleColor.DarkGray; break;
                    case '9': Console.ForegroundColor = ConsoleColor.Blue; break;
                    case 'a': Console.ForegroundColor = ConsoleColor.Green; break;
                    case 'b': Console.ForegroundColor = ConsoleColor.Cyan; break;
                    case 'c': Console.ForegroundColor = ConsoleColor.Red; break;
                    case 'd': Console.ForegroundColor = ConsoleColor.Magenta; break;
                    case 'e': Console.ForegroundColor = ConsoleColor.Yellow; break;
                    case 'f': Console.ForegroundColor = ConsoleColor.White; break;
                    default: Color = false; break;
                }
                if (Color)
                    Console.Write(Segments[i].Substring(1));
                else
                    Console.Write("&" + Segments[i]);
            }
            Console.ForegroundColor = p;
        }
        public static void WriteLineColor(string Text)
        {
            ConsoleColor p = Console.ForegroundColor;
            string[] Segments = Text.Split('&');
            Console.Write(Segments[0]);
            for (int i = 1; i < Segments.Length; i++)
            {
                bool Color = true;
                switch (Segments[i].ToLower().ToCharArray()[0])
                {
                    case '0': Console.ForegroundColor = ConsoleColor.Black; break;
                    case '1': Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                    case '2': Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                    case '3': Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                    case '4': Console.ForegroundColor = ConsoleColor.DarkRed; break;
                    case '5': Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                    case '6': Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                    case '7': Console.ForegroundColor = ConsoleColor.Gray; break;
                    case '8': Console.ForegroundColor = ConsoleColor.DarkGray; break;
                    case '9': Console.ForegroundColor = ConsoleColor.Blue; break;
                    case 'a': Console.ForegroundColor = ConsoleColor.Green; break;
                    case 'b': Console.ForegroundColor = ConsoleColor.Cyan; break;
                    case 'c': Console.ForegroundColor = ConsoleColor.Red; break;
                    case 'd': Console.ForegroundColor = ConsoleColor.Magenta; break;
                    case 'e': Console.ForegroundColor = ConsoleColor.Yellow; break;
                    case 'f': Console.ForegroundColor = ConsoleColor.White; break;
                    default: Color = false; break;
                }
                if (Color)
                    Console.Write(Segments[i].Substring(1));
                else
                    Console.Write("&" + Segments[i]);
            }
            Console.WriteLine();
            Console.ForegroundColor = p;
        }
    }
}
