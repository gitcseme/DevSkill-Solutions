using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_190
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int caseno = 1; caseno <= t; ++caseno)
            {
                long a, b;
                string[] s = Console.ReadLine().Split(' ');
                a = long.Parse(s[0]);
                b = long.Parse(s[1]);
                
                if (b % a != 0)
                {
                    Console.WriteLine("Case {0}: 0", caseno);
                }
                else
                {
                    long ans = NOD(b / a);
                    Console.WriteLine("Case {0}: {1}", caseno, ans);
                }

            }
        }

        private static long NOD(long n)
        {
            long nod = 1;
            for(long i = 2; i*i <= n; ++i)
            {
                int cnt = 0;
                while (n%i == 0)
                {
                    n /= i;
                    ++cnt;
                }
                nod = nod * (cnt + 1);
            }
            if (n > 1) nod = nod * 2;
            return nod;
        }
    }
}
