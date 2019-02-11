using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_5
    {
        static void Main(string[] args)
        {
            long a, b, c;
            string line;
            
            while ((line = Console.ReadLine()) != null)
            {
                string[] s = line.Split(' ');
                a = long.Parse(s[0]);
                b = long.Parse(s[1]);
                c = long.Parse(s[2]);

                //long ans = recur(a, b, c);
                long max = Math.Max(a, Math.Max(b, c));
                long min = Math.Min(a, Math.Min(b, c));
                long mid = (a + b + c) - (max + min);
                Console.WriteLine(min + mid + mid);
            }
        }

        private static long recur(long a, long b, long c)
        {
            if (a > b && a > c) return recur(a - 1, b, c);
            if (b > a && b > c) return recur(a, b - 1, c);
            if (c > a && c > b) return recur(a, b, c - 1);

            return (a + b + c);
        }
    }
}
