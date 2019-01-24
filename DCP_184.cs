using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_184
    {
        static void Main()
        {
            long[] fib = new long[50];
            fib[1] = 1;
            fib[2] = 3;

            for (int i = 3; i <= 45; ++i)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(fib[n]);
            }
        }
    }
}
