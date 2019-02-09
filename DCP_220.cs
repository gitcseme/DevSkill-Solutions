using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_220
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n;
            for (int caseno = 1; caseno <= t; caseno++)
            {
                n = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                Console.Write("Case {0}: ", caseno);

                if (n == 1)
                {
                    Console.WriteLine(s[0]);
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
