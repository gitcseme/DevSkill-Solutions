using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_85
    {
        static void Main ()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 30 || n == 29)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
