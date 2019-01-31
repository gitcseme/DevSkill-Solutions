using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_586
    {
        static void Main()
        {
            int b, s, g, t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] a = Console.ReadLine().Split(' ');
                b = int.Parse(a[0]);
                s = int.Parse(a[1]);
                g = int.Parse(a[2]);

                int score = b * 10 + s * 50 + g * 100;
                Console.WriteLine(score);
            }
        }
    }
}
