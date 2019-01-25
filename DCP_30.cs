using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_30
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            for (int caseno = 1; caseno <= t; caseno++)
            {
                int[] cnt = new int[26];
                for (int i = 0; i < 26; i++) cnt[i] = 0;
                char[] c = Console.ReadLine().ToCharArray();

                for (int i = 0; i < c.Length; i++) ++cnt[(c[i] - 'a')];

                Console.WriteLine("Case {0}:", caseno);
                for (int i = 0; i < 26; i++)
                {
                    if (cnt[i] != 0)
                        Console.WriteLine("{0} {1}", (char)(97+i), cnt[i]);
                }
            }
        }
    }
}
