using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_374
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            long n;

            while (t-- > 0)
            {
                n = long.Parse(Console.ReadLine());
                string bits = Convert.ToString(n, 2);
                Console.WriteLine(bits.Length);
            }
        }
    }
}
