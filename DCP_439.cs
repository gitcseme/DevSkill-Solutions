using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_439
    {
        static void Main()
        {
            int cnt, n, t = int.Parse(Console.ReadLine());
            for (int caseno = 1; caseno <= t; caseno++)
            {
                n = int.Parse(Console.ReadLine());
                char[] c = Console.ReadLine().ToCharArray();
                cnt = 0;
                bool prev = false;
                for (int i = 0; i < n; ++i)
                {
                    if (isVowel(c[i]))
                    {
                        if (prev == false)
                            ++cnt;
                        prev = true;
                    }
                    else prev = false;
                }

                Console.WriteLine("Case {0}: {1}", caseno, cnt);
            }
        }

        private static bool isVowel(char v)
        {
            if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
                return true;
            return false;
        }
    }
}
