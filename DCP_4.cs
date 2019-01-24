using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_4
    {
        static void Main()
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] a = line.Split(' ');
                int total = int.Parse(a[0]);
                int n = int.Parse(a[1]);
                int h = 0;
                while (n-- > 0) {
                    h += int.Parse(Console.ReadLine());
                }

                int ans = (int) Math.Ceiling((double)total / h);
                if (ans > 1) {
                    Console.WriteLine("Project will finish within {0} days.", ans);
                }
                else {
                    Console.WriteLine("Project will finish within 1 day.");
                }
            }
        }
    }
}
