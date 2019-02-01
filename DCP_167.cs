using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_167
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int caseno = 1; caseno <= t; caseno++)
            {
                long n = long.Parse(Console.ReadLine());
                n = ((n * n) * (n + 1) * (n + 1)) / 4;
                Console.WriteLine("Case {0}: {1}", caseno, n);
            }
        }
    }
}
