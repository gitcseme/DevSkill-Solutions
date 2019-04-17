using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_443
    {
        static void Main(string[] args)
        {
            //Console.SetIn(new StreamReader("../../inp.txt"));

            int t = int.Parse(Console.ReadLine());
            int n;
            for (int c = 1; c <= t; ++c)
            {
                n = int.Parse(Console.ReadLine());
                if (n == 1 || n == 3)
                    Console.WriteLine("Case {0}-> YES;", c);
                else
                    Console.WriteLine("Case {0}-> NO;", c);
            }
        }
    }
}
