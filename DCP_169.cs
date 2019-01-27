using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class Pair {
        public int x, y;
        public Pair (int xx, int yy) {
            x = xx;
            y = yy;
        }
    }
    class DCP_169
    {
        static void Main ()
        {
            List<Pair> gold = new List<Pair>();
            int t = int.Parse(Console.ReadLine());
            int r, c;
            for (int caseno = 1; caseno <= t; caseno++)
            {
                string[] s = Console.ReadLine().Split(' ');
                r = int.Parse(s[0]);
                c = int.Parse(s[1]);
                bool found = false;

                for (int i = 0; i < r; i++)
                {
                    char[] a = Console.ReadLine().ToCharArray();
                    for (int j = 0; j < c; j++)
                        if (a[j] == '$') {
                            gold.Add(new Pair(i + 1, j + 1));
                            found = true;
                        }
                }
                Console.WriteLine("Case {0}:", caseno);
                if (found) {
                    foreach (Pair p in gold)
                    {
                        Console.WriteLine("{0},{1}", p.x, p.y);
                    }
                }
                else
                    Console.WriteLine("No Gold Found");
                gold.Clear();
            }
        }

    }
}
