using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ckorost
{
    internal class Tekst
    {
        public int[] text()
        {
            long time = 0;
            int txt = 0;
            string s = "Глядя на левую сторону дороги и сам того не зная, не узнавая его, любовался тем дубом, которого он искал.Старый дуб, весь преображенный, раскинувшись шатром сочной, темной зелени, млел, чуть колыхаясь в лучах вечернего солнца. Ни корявых пальцев, ни болячек, ни старого недоверия и горя, ничего не было видно.";
            char[] a = s.ToCharArray();
                Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < 308; i++)
            {
                char k = a[i];
                while (true)
                {
                stopwatch.Restart();
                    char key = Console.ReadKey(true).KeyChar;
                    if (key == k)
                    {
                        txt = txt + 1;
                        if (i > 208)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(i - 209, 2);
                            Console.WriteLine(k);
                        }
                        else
                        {
                            if (i < 105)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(i, 0);
                                Console.WriteLine(k);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(i - 105, 1);
                                Console.WriteLine(k);
                            }
                        }
                        break;
                    }
                    stopwatch.Stop();

                    time = time + stopwatch.ElapsedMilliseconds;
                    if (time > 60000)
                    {
                        time = 60000;
                        break;
                    }
                }
                if (time == 60000)
                {
                    break;
                }
            }
            int tim =Convert.ToInt32( time / 1000);
            int[] back = { txt, tim };
            return back;
        }
    }
}
