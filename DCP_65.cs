using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_65
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Ceiling((Math.Sqrt(1.0 + 8 * x) - 1) / 2));
            }
        }
    }
}
