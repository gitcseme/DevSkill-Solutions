using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_14
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            double a, b, c, ad;

            while (t-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                a = double.Parse(s[0]);
                b = double.Parse(s[1]);
                c = double.Parse(s[2]);

                ad = Math.Sqrt(a * a + b * b + c * c);
                Console.WriteLine($"{ad:F2}");
            }
        }
    }
}
