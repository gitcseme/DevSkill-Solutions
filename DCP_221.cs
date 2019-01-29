using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_221
    {
        static void Main ()
        {
            int x, t = int.Parse(Console.ReadLine());
            for (int caseno = 1; caseno <= t; caseno++)
            {
                int max = 0, min = 99999;
                string[] a = Console.ReadLine().Split(' ');
                int len = a.Length;

                for (int i = 0; i < len; i++)
                {
                    x = int.Parse(a[i]);
                    if (x > max) max = x;
                    if (x < min) min = x;
                }
                Console.WriteLine("Case {0}: Among {1} numbers {2} is maximum and {3} is minimum", caseno, len, max, min);
            }
        }
    }
}
