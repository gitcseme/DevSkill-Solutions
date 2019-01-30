using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_467
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string s = Console.ReadLine();
                Console.WriteLine("Happy New Year-{0}", (2018 + (s.Length - 12)));
            }
        }
    }
}
