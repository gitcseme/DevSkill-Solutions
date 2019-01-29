using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_308
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            int year;
            string a0, a1, a2;
            while (t-- > 0)
            {
                string[] a = Console.ReadLine().Split(' ');
                year = int.Parse(a[3]);
                if (a[1] == "nobo") {
                    a0 = "Shuva";
                    a1 = "naya";
                    a2 = "barsha";
                    year = year + 650;
                }
                else {
                    a0 = "Shuvo";
                    a1 = "nobo";
                    a2 = "borsho";
                    year = year - 650;
                }
                Console.WriteLine("{0} {1} {2} {3}", a0, a1, a2, year);
            }
        }
    }
}
