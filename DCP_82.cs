using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_82
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                if (n >= 120)
                    Console.WriteLine("Good Boy Sifat");
                else
                    Console.WriteLine("Naughty Boy Sifat");
            }
        }
    }
}
