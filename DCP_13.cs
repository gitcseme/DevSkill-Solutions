using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_13
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            int b, p;
            while (t-- > 0)
            {
                bool m1 = false;
                bool m2 = false;
                for (int i = 0; i < 2; ++i)
                {
                    b = p = 0;
                    string[] scores = Console.ReadLine().Split(' ');
                    b = int.Parse(scores[0]) + int.Parse(scores[1]);
                    p = int.Parse(scores[2]) + int.Parse(scores[3]);

                    if (b > p && i == 0) m1 = true;
                    if (b > p && i == 1) m2 = true;
                        
                }
                if (m1 && m2) Console.WriteLine("Banglawash");
                else Console.WriteLine("Miss");
            }
        }
    }
}
