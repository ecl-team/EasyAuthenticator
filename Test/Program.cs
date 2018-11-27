using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using authlib;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Authentication.CurrentCode(""));
            Console.ReadLine();
        }
    }
}
