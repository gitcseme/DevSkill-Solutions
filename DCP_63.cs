using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_63
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string a, b, s;

            while (t-- > 0)
            {
                a = Console.ReadLine();
                b = Console.ReadLine();
                s = a + a;
                if (a.Length != b.Length || !s.Contains(b))
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");
            }
        }
    }
}
