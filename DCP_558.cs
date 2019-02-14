using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_558
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            ulong k, evenSum, oddSum;

            while (t-- > 0)
            {
                k = ulong.Parse(Console.ReadLine());
                //evenSum = getEvenSum(k);
                //oddSum = getOddSum(k);
                //Console.WriteLine(evenSum - oddSum);
                Console.WriteLine(k);
            }
        }

        private static ulong getOddSum(ulong k)
        {
            ulong n = k - 1;
            n = (n * k) / 2;
            ulong first = 1 + (n * 2);
            ulong sum = (k * (2 * first + ((k-1) * 2))) / 2;
            return sum;
        }

        private static ulong getEvenSum(ulong k)
        {
            ulong n = k - 1;
            n = (n * k) / 2;
            ulong first = 2 + (n * 2);
            ulong sum = (k * (2 * first + ((k - 1) * 2))) / 2;
            return sum;
        }
    }
}
