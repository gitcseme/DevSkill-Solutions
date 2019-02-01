using System;
using System.Text;

namespace DevSkill_Problems
{
    class DCP_419
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            int[] a = new int[100005];
            int[] b = new int[100005];
            int n, best, best_index;

            while (t-- > 0)
            {
                n = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                for (int i = 0; i < n; ++i) a[i] = int.Parse(s[i]);

                best = -1;
                best_index = n - 1;
                for (int i = n-1; i >= 0; --i)
                {
                    if (best <= a[i])
                    {
                        best = a[i];
                        best_index = i;
                    }
                    b[i] = best_index - i;
                }

                StringBuilder ans = new StringBuilder("");

                for (int i = 0; i < n; ++i)
                {
                    ans.Append(b[i]);
                    if (i != n - 1) ans.Append(" ");
                }
                Console.WriteLine(ans.ToString());
            }
        }
    }
}
