using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_210
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            long n;
            while (t-- > 0)
            {
                n = long.Parse(Console.ReadLine());
                n--;
                n = (n * (4 + (n - 1) * 4)) / 2;
                Console.WriteLine(n);
            }
        }
    }
}
