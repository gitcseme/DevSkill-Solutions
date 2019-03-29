using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_36
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] a = new int[3];
            int[] b = new int[3];

            for (int caseno = 1; caseno <= t; ++caseno)
            {
                string[] g = Console.ReadLine().Split(' ');
                a[0] = int.Parse(g[0]);
                a[1] = int.Parse(g[1]);
                a[2] = int.Parse(g[2]);
                string[] h = Console.ReadLine().Split(' ');
                b[0] = int.Parse(h[0]);
                b[1] = int.Parse(h[1]);
                b[2] = int.Parse(h[2]);

                bool Swapnil = false, Shibli = false;
                for (int i = 0; i < 3; i++)
                {
                    if (a[i] > b[0] || a[i] > b[1] || a[i] > b[2]) Swapnil = true;
                    if (b[i] > a[0] || b[i] > a[1] || b[i] > a[2]) Shibli = true;
                }

                Console.Write("Case {0}: ", caseno);
                if (Swapnil && Shibli)
                    Console.WriteLine("Both can win");
                else if (Swapnil)
                    Console.WriteLine("Swapnil wins");
                else
                    Console.WriteLine("Shibli wins");
            }
        }
        
    }
}
