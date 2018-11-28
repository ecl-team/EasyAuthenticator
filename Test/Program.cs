using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using authlib;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string Token = EBase64.Generate(64);
            ConsoleLib.Write("Token: ", ConsoleColor.Red);
            Console.WriteLine(Token);
            string LastCode = "";
            while(true)
            {
                if (LastCode != Authentication.CurrentCode(Token))
                {
                    ConsoleLib.Write("New Code: ", ConsoleColor.Red);
                    Console.WriteLine(Authentication.CurrentCode(Token));
                    LastCode = Authentication.CurrentCode(Token);
                }
                Thread.Sleep(100);
            }
        }
    }
}
