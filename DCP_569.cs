using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_569
    {
        static void Main(string[] args)
        {
            int N, t = int.Parse(Console.ReadLine());
            string name = "";
            int skill, local;

            while (t-- > 0)
            {
                N = int.Parse(Console.ReadLine());
                skill = 0;
                while (N-- > 0)
                {
                    string[] a = Console.ReadLine().Split(' ');
                    local = int.Parse(a[1]);
                    if (local >= skill)
                    {
                        name = a[0];
                        skill = local;
                    }
                }

                Console.WriteLine(name);
            }
        }
    }
}
