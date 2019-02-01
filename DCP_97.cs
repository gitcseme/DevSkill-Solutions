using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_97
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            Dictionary<char, int> cnt = new Dictionary<char, int>();
            
            while (t-- > 0)
            {
                HashSet<char> hs = new HashSet<char>();
                cnt['T'] = 0;
                cnt['M'] = 0;
                cnt['F'] = 0;
                cnt['J'] = 0;
                int n = int.Parse(Console.ReadLine());
                char[] c = Console.ReadLine().ToCharArray();
                int min_range = n;

                for (int i = 0, j = 0; j < n || i <= n-4; )
                {
                    if (hs.Count == 4)
                    {
                        min_range = Math.Min(min_range, j - i);
                        cnt[c[i]]--;
                        if (cnt[c[i]] == 0) hs.Remove(c[i]);
                        ++i;
                    }
                    else if (j < n)
                    {
                        hs.Add(c[j]);
                        if (hs.Count == 4) min_range = Math.Min(min_range, (j - i) + 1);
                        cnt[c[j]]++;
                        ++j;
                    }
                    else
                    {
                        cnt[c[i]]--;
                        ++i;
                        if (cnt[c[i]] == 0) break;
                    }
                }
                Console.WriteLine(min_range);
            }
        }
    }
}
