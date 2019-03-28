using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_310
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long x;
            long k;
            long[] a = new long[n];
            string[] s1 = Console.ReadLine().Split(' ');
            string[] s2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) a[i] = long.Parse(s1[i]);
            x = long.Parse(s2[0]);
            k = long.Parse(s2[1]);

            long left, right;
            if (x - k <= 0) left = 0;
            else left = (x - k - 1);

            if (x + k > n) right = n - 1;
            else right = (x + k - 1);

            long baseheight = a[x - 1], count = 0;
            for (int i = (int)left; i <= right; ++i)
                if (a[i] > baseheight)
                    ++count;

            Console.WriteLine(count);
        }
    }
}
