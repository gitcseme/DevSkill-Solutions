using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_420
    {
        static void Main(string[] args)
        {
            int n, t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                n = int.Parse(Console.ReadLine());
                int[] a = new int[n + 5];
                string[] s = Console.ReadLine().Split(' ');
                int low = 100000;
                for (int i = 0; i < n; ++i)
                {
                    a[i] = int.Parse(s[i]);
                    low = Math.Min(low, a[i]);
                }
                long cost = 0;
                for (int i = 0; i < n; ++i) cost += a[i] - low;

                Console.WriteLine(cost);
            }
        }
    }
}
