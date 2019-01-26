using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_111
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                ulong x = ulong.Parse(Console.ReadLine());
                ulong line = (ulong)(Math.Sqrt(1 + 8.0 * x) - 1) / 2;
                Console.WriteLine("{0}\n{1}", line, (x - ((line*(line+1)) / 2)));
            }
        }
    }
}
