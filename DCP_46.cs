using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_46
    {
        public static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string[] a = Console.ReadLine().Split(' ');
                Decimal x = Decimal.Parse(a[0]);
                Decimal y = Decimal.Parse(a[1]);
                Console.WriteLine(Math.Floor((x + y) / 2));
            }
        }
    }
}
