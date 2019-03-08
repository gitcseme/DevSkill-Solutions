using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_106
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int caseno = 1; caseno <= t; caseno++)
            {
                int N = int.Parse(Console.ReadLine().Trim());
                string[] a = Console.ReadLine().Split(' ');
                int getOut = 0, score = 0, len = a.Length;

                for (int i = 0; i < len; i++)
                {
                    if (getOut == N)
                        break;
                    else if (a[i] == "0")
                        getOut++;
                    else
                    {
                        score = score + getRun(a[i]); // int.parse(a[i])  --> gives runtime error.
                    }
                }

                Console.WriteLine("Case {0}: {1}", caseno, score);
            }
        }

        private static int getRun(string v)
        {
            int run = 0;
            switch(v)
            {
                case "1":
                    run = 1;
                    break;
                case "2":
                    run = 2;
                    break;
                case "3":
                    run = 3;
                    break;
                case "4":
                    run = 4;
                    break;
                case "5":
                    run = 5;
                    break;
                case "6":
                    run = 6;
                    break;
            }
            return run;
        }
    }
}
