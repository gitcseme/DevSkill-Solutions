using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_444
    {
        static void Main(string[] args)
        {
            //Console.SetIn(new StreamReader("../../inp.txt"));

            int t = int.Parse(Console.ReadLine());
            int n;
            long a, b;

            while (t-- > 0)
            {
                a = long.Parse(Console.ReadLine());
                b = long.Parse(Console.ReadLine());
                n = int.Parse(Console.ReadLine());
                bool okay = true;
                long cur = a;

                while (n-- > 0)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    if (s[0] == "in")
                        cur += long.Parse(s[1]);
                    else
                    {
                        long amount = long.Parse(s[1]);
                        if (cur < amount) okay = false;
                        cur -= amount;
                    }
                }

                if (okay && (cur == b))
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }
        }
    }
}
