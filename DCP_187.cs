using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_187
    {
        static long[] f = new long[60];

        static void Main(string[] args)
        {
            populate();
            int chocolate;
            string s;
            
            while ((s = Console.ReadLine()) != null)
            {
                chocolate = int.Parse(s);

                if (chocolate == 1)
                {
                    Console.WriteLine("Showmic brings 1 chocolate on 1st day.");
                }
                else if (chocolate == 2)
                {
                    Console.WriteLine("Showmic brings 2 chocolates on 2nd day.");
                }
                else if (chocolate == 3)
                {
                    Console.WriteLine("Showmic brings 3 chocolates on 3rd day.");
                }
                else
                {
                    int day = 1, i = 2;
                    while (f[i] != chocolate)
                    {
                        ++day;
                        ++i;
                    }

                    Console.WriteLine("Showmic brings {0} chocolates on {1}th day.", chocolate, day);
                }
            }
            
        }

        static void populate()
        {
            f[0] = 0; f[1] = 1;
            for (int i = 2; i < 60; i++)
                f[i] = f[i - 1] + f[i - 2];
        }
    }
}
