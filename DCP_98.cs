using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_98
    {
        static void Main(string[] args)
        {
            int n, S, t = int.Parse(Console.ReadLine());

            for (int caseno = 1; caseno <= t; caseno++)
            {
                string[] s = Console.ReadLine().Split(' ');
                n = int.Parse(s[0]);
                S = int.Parse(s[1]);

                string[] b = Console.ReadLine().Split(' ');
                int[] a = new int[n];
                for (int i = 0; i < n; i++) a[i] = int.Parse(b[i]);

                int minLength = int.MaxValue, local = 0;
                bool okay = false;
                for (int l = 0, r = 0; l < n || r < n; )
                {
                    if (local < S && r < n)
                    {
                        local = local + a[r];
                        ++r;
                    }
                    else if (local < S && l < n)
                    {
                        local -= a[l];
                        ++l;
                    }
                    if (local >= S && l < n)
                    {
                        okay = true;
                        minLength = Math.Min(minLength, r - l);
                        local -= a[l];
                        ++l;
                    }
                }

                if (okay)
                {
                    Console.WriteLine("Case {0}: {1}",caseno, minLength);
                }
                else Console.WriteLine("Case {0}: -1", caseno);
            }
        }
    }
}
