using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_192
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            int n;

            for (int caseno = 1; caseno <= t; ++caseno)
            {
                ulong cycle, cost, minCycle = ulong.MaxValue, minCost = ulong.MaxValue;
                n = int.Parse(Console.ReadLine());

                while (n-- > 0)
                {
                    string[] a = Console.ReadLine().Split(' ');
                    cycle = ulong.Parse(a[0]);
                    cost = ulong.Parse(a[1]);

                    if (cycle < minCycle)
                    {
                        minCycle = cycle;
                        minCost = cost;
                    }
                    else if (cycle == minCycle)
                    {
                        minCost = Math.Min(minCost, cost);
                    }
                }
                Console.WriteLine("Case {0}: {1} {2}", caseno, minCycle, minCost);
            }
        }
    }
}
