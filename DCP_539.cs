using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_539
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                long d = long.Parse(Console.ReadLine());
                int r = (int)(d % 3);

                if (r == 0) Console.WriteLine("1");
                else if (r == 1) Console.WriteLine("2");
                else Console.WriteLine("4");
            }
        }
    }
}
