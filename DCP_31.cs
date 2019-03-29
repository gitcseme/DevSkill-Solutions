using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_31
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()), p, x, y, cnt, p2;

            while (t-- > 0)
            {
                string[] a = Console.ReadLine().Split(' ');
                x = int.Parse(a[0]);
                y = int.Parse(a[1]);
                p = int.Parse(a[2]);
                p2 = p;
                p = p + 5;

                StringBuilder ans = new StringBuilder("");
                if (x < y) ans.Append(0);

                bool f = true;
                for (int i = 1; i <= p; i++)
                {
                    cnt = 0;
                    while (x < y)
                    {
                        if (f) ans.Append('.');
                        f = false;
                        if (cnt > 0)
                        {
                            ans.Append(0);
                            ++i;
                        }
                        x *= 10;
                        ++cnt;
                        if (i >= p) break;
                    }
                    if (i >= p) break;
                    ans.Append(x / y);
                    x = x % y;
                }

                string s = ans.ToString();
                int dot = s.IndexOf('.');
                s = s.Substring(0, (dot + 1)) + s.Substring((dot + 1), p2);
                Console.WriteLine(s);
            }
        }
    }
}
