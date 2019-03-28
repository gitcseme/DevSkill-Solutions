using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_354
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                long n = long.Parse(Console.ReadLine());
                long trailingZeros = numberOfTrailingZeroInFactoria(n);
                bool pow2 = IsPowerOf2(trailingZeros);

                if (pow2) Console.WriteLine("Even");
                else Console.WriteLine("Odd");
            }
        }

        private static bool IsPowerOf2(long n)
        {
            if (n == 0) return false;
            return Math.Ceiling(Math.Log(n, 2)) == Math.Floor(Math.Log(n, 2));
        }

        private static long numberOfTrailingZeroInFactoria(long n)
        {
            long count = 0;
            for (long i = 5; n / i > 0; i *= 5)
                count += (n / i);

            return count;
        }
    }
}
