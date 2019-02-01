using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_20
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            int cx, cy, px, py;
            double R;

            for (int caseno = 1; caseno <= t; caseno++)
            {
                string[] a = Console.ReadLine().Split(' ');
                cx = int.Parse(a[0]);
                cy = int.Parse(a[1]);
                R = double.Parse(a[2]);
                px = int.Parse(a[3]);
                py = int.Parse(a[4]);

                double d = Math.Sqrt((cx - px) * (cx - px) + (cy - py) * (cy - py));

                Console.Write("Case {0}: ", caseno);
                if (d == R)
                    Console.WriteLine("OnCircle");
                else if (d < R)
                    Console.WriteLine("Inside");
                else
                    Console.WriteLine("Outside");
            }
        }
    }
}
