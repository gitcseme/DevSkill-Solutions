using System;
using System.Linq;
using System.Text;

namespace DevSkill_Problems
{
    class DCP_1
    {
        static void Main ()
        {
            string s, n1, n2;

            while ((s = Console.ReadLine()) != null)
            {
                string[] a = s.Split(',');
                n1 = new string(a[0].Reverse().ToArray());
                n2 = new string(a[1].Reverse().ToArray());

                int mxLen = Math.Max(n1.Length, n2.Length);
                StringBuilder s1 = new StringBuilder(n1);
                int len = n1.Length;
                for (int i = 0; i < mxLen-len; i++) s1.Insert(0, '0');
                char[] a1 = s1.ToString().ToCharArray();

                StringBuilder s2 = new StringBuilder(n2);
                len = n2.Length;
                for (int i = 0; i < mxLen-len; i++) s2.Insert(0, '0');
                char[] a2 = s2.ToString().ToCharArray();

                StringBuilder ans = new StringBuilder("");
                int carry = 0, x, y, add;
                for (int i = mxLen-1; i >= 0; --i)
                {
                    x = a1[i] - '0';
                    y = a2[i] - '0';
                    add = x + y + carry;
                    if (add >= 10) carry = 1;
                    else carry = 0;
                    ans.Append(add % 10);
                }
                if (carry == 1) ans.Append(1);
                string f = ans.ToString();

                if (f.Length == 1 && f[0] == '0')
                {
                    Console.WriteLine();
                    continue;
                }

                while (f[0] == '0') f = f.Substring(1);

                Console.WriteLine(f);
            }
        }
    }
}
