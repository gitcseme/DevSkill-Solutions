using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_162
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            long n, i;

            while (t-- > 0)
            {
                n = long.Parse(Console.ReadLine());

                for (i = (long)Math.Sqrt(n+0.01); i >= 1; --i)
                    if (n % i == 0)
                        break;

                Console.WriteLine((n / i) - i);
            }
        }
    }
}
