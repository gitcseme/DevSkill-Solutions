using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_74
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            for (int caseno = 1; caseno <= t; caseno++)
            {
                ulong n = ulong.Parse(Console.ReadLine());
                Console.Write("Case #{0}: ", caseno);
                bool e = (n % 2 == 0);

                n = n * 3;
                if (e) Console.WriteLine("{0} {1} {2}", n, n - 1, n - 2);
                else Console.WriteLine("{0} {1} {2}", n - 2, n - 1, n);
            }
        }
    }
}
