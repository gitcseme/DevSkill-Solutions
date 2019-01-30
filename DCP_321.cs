using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_321
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                char[] c = Console.ReadLine().ToCharArray();
                int len = c.Length;
                for (int i = 0; i < len; i++)
                {
                    if (c[i] == ' ') continue;
                    if (65 <= c[i] && c[i] <= 90)
                    {
                        c[i] = (char)('a' + (c[i] - 'A'));
                    }
                    else
                    {
                        c[i] = (char)('A' + (c[i] - 'a'));
                    }
                }
                Console.WriteLine(new string(c));
            }
        }
    }
}
