using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_275
    {
        static void Main(string[] args)
        {
            //Console.SetIn(new StreamReader("../../inp.txt"));

            int t = int.Parse(Console.ReadLine());
            int n, p, count;

            while (t-- > 0)
            {
                n = int.Parse(Console.ReadLine());
                int[] a = new int[n + 5];
                for (int i = 0; i <= n + 2; ++i) a[i] = 0;

                count = 0;
                for (int i = 0; i < n-1; i++)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    p = int.Parse(s[0]);

                    if (a[p] != -1) ++count;
                    a[p] = -1;
                }

                Console.WriteLine(n-count);
            }
        }
    }
}
