using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_27
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n;

            while (t-- > 0)
            {
                n = int.Parse(Console.ReadLine());
                if (n == 0 || n == 1)
                {
                    Console.WriteLine("No");
                    continue;
                }
                int sqr = (int)(Math.Sqrt(n) + 1);
                bool isP = true;

                for (int i = 2; i < sqr; i++)
                {
                    if (n%i == 0)
                    {
                        isP = false;
                        break;
                    }
                }
                if (isP)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }
    }
}
