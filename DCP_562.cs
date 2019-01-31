using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_562
    {
        static void Main ()
        {
            int a, b, t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                a = int.Parse(s[0]);
                b = int.Parse(s[1]);

                if (a > b)
                    Console.WriteLine("Argentina {0} - {1} Brazil", a, b);
                else
                    Console.WriteLine("Brazil {0} - {1} Argentina", b, a);
            }
        }
    }
}
