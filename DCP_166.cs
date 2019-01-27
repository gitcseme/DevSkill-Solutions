using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_166
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            int item, Q;
            double P, deposite, total_shoping;
            for (int caseno = 1 ; caseno <= t; caseno++)
            {
                item = int.Parse(Console.ReadLine());
                total_shoping = 0;
                for (int i = 0; i < item; i++)
                {
                    string[] a = Console.ReadLine().Split(' ');
                    P = double.Parse(a[0]);
                    Q = int.Parse(a[1]);

                    total_shoping += (P * Q);
                }
                deposite = double.Parse(Console.ReadLine());
                Console.WriteLine("Case {0}: {1}", caseno , (int)(deposite - total_shoping));
            }
        }
    }
}
