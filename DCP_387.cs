using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_387
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int caseno = 1; caseno <= t; ++caseno)
            {
                char[] c = Console.ReadLine().ToCharArray();
                StringBuilder ans = new StringBuilder("");

                ans.Append(c[0]);
                if (c.Length > 1)
                {
                    int i = 1;
                    while (c[i] != '.')
                    {
                        if (char.IsUpper(c[i])) ans.Append(' ');
                        ans.Append(c[i]);
                        ++i;
                    }
                }
                Console.WriteLine("Case #{0} -> {1}", caseno, ans.ToString());
            }
        }
    }
}
