using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_500
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            long a, b;

            while (t-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                a = long.Parse(s[0]);
                b = long.Parse(s[1]);

                if (b != 0 && a%b == 0)
                    Console.WriteLine(":wink:");
                else
                    Console.WriteLine(":kick:");
            }
        }
    }
}
