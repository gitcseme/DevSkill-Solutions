using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_423
    {
        static void Main(string[] args)
        {
            int[] p = new int[100005];
            p[0] = p[1] = 0;
            for (int i = 2; i < 100005; ++i)
            {
                if (IsPrimeMagical(i))
                    p[i] = p[i - 1] + 1;
                else
                    p[i] = p[i - 1];
            }

            int t = int.Parse(Console.ReadLine());
            int n;
            while (t-- > 0)
            {
                n = int.Parse(Console.ReadLine());
                Console.WriteLine(p[n]);
            }
        }

        private static bool IsPrimeMagical(int n)
        {
            int d;
            while (n != 0)
            {
                d = n % 10;
                if (d == 2 || d == 3 || d == 5 || d == 7) return true;
                n = n / 10;
            }
            return false;
        }
    }
}
