using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using authlib;
using QRCoder;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine(Authentication.CurrentCode("Eclipsum"));
                Thread.Sleep(1000);
            }
        }

        public static void BreachTest()
        {
            int Loops = 0;
            int Similarities = 0;
            DateTime Now = DateTime.Now;
            while (true)
            {
                ConsoleLib.WriteLineColor("&cCreating 65536 tokens...");
                List<string> Codes = new List<string>();
                Stopwatch t = new Stopwatch();
                t.Start();
                for (int i = 0; i < 65536; i++)
                {
                    string Token = EBase64.Generate(64);
                    Codes.Add(Authentication.CurrentCode(Token));
                }
                t.Stop();
                ConsoleLib.WriteLineColor("&aFinished job, took &e" + t.ElapsedMilliseconds + " ms");
                ConsoleLib.WriteLineColor("&cChecking code similarities...");
                Dictionary<string, int> Sim = new Dictionary<string, int>();
                t.Reset();
                t.Start();
                foreach (string Code in Codes)
                {
                    if (!Sim.Keys.Contains(Code))
                    {
                        int s = 0;
                        foreach (string Code1 in Codes)
                        {
                            if (Code == Code1)
                                s++;
                        }
                        if (s > 1)
                            Sim.Add(Code, s);
                    }
                }
                t.Stop();
                int SimCount = 0;
                foreach (int Value in Sim.Values)
                {
                    SimCount += Value - 1;
                }
                ConsoleLib.WriteLineColor("&aFinished job, took &e" + t.ElapsedMilliseconds + " ms");
                ConsoleLib.WriteLineColor("&aFound &e" + SimCount + " &asimilarities.");
                Similarities += SimCount;
                Loops++;
                ConsoleLib.WriteLineColor("&aChance of breach: &e" + (double)Similarities / Loops / 655.36 + "%\n");
            }
        }
    }
}
