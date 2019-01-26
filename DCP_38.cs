using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_38
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string first = "", last = "";
                int max = -1, min = 1000000 + 6;
                while (n-- > 0)
                {
                    string[] a = Console.ReadLine().Split(' ');
                    int time = int.Parse(a[1]);
                    if (time > max)
                    {
                        max = time;
                        first = a[0];
                    }
                    if (time < min)
                    {
                        min = time;
                        last = a[0];
                    }
                }

                Console.WriteLine("{0} {1}", first, last);
            }
        }
    }
}
