using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_69
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int me = 0, cat = 0, x;
                int n = int.Parse(Console.ReadLine());

                string[] a = Console.ReadLine().Split(' ');
                for (int i = 0; i < n; i++)
                {
                    x = int.Parse(a[i]);
                    me += x;
                    if (x >= i) cat += (x - i);
                }

                Console.WriteLine(me - cat);
            }
        }
    }
}
