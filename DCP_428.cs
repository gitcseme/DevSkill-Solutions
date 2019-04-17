using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_428
    {
        static void Main(string[] args)
        {
            //Console.SetIn(new StreamReader("../../inp.txt"));

            int t = int.Parse(Console.ReadLine());
            int n;

            while (t-- > 0)
            {
                n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                string[] s = Console.ReadLine().Split(' ');
                for (int i = 0; i < n; ++i) a[i] = int.Parse(s[i]);

                int uniqPartition = 1;
                for (int i = 1; i < n; i++)
                {
                    if (a[i] == a[i - 1]) continue;
                    ++uniqPartition;
                }

                Console.WriteLine(uniqPartition);
            }
        }
    }
}
