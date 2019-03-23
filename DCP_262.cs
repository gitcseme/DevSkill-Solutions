using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_262
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n;

            while (t-- > 0)
            {
                n = int.Parse(Console.ReadLine());
                if (n == 1)
                    Console.WriteLine("1 000");
                else if (n == 2)
                    Console.WriteLine("2 010");
                else
                    Console.WriteLine("{0} 110", n);
            }
        }
    }
}
