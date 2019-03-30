using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_64
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()), n, a, b;

            for (int caseno = 1; caseno <= t; caseno++)
            {
                n = int.Parse(Console.ReadLine());
                int[] time = new int[10010];
                for (int i = 0; i < 10010; i++) time[i] = 0;

                for (int i = 0; i < n; i++)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    a = int.Parse(s[0]);
                    b = int.Parse(s[1]);
                    for (int j = a; j <= b; ++j) ++time[j];
                }
                int mx = 0;
                for (int i = 1; i <= 1000; i++)
                    if (time[i] > mx) mx = time[i];

                Console.WriteLine("Case {0}: {1}", caseno, mx);
            }
        }
    }
}
