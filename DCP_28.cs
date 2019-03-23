using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_28
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            double R, S, sr;

            while (t-- > 0)
            {
                string[] a = Console.ReadLine().Split(' ');
                R = double.Parse(a[0]);
                S = double.Parse(a[1]);

                sr = Math.Sqrt(2 * S * S) / 2;
                sr = Math.Round(sr, 2);

                if (R == sr)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }

        }
    }
}
