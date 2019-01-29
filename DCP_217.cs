using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_217
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            char[] num = new char[30];
            int rep, len;
            for (int caseno = 1; caseno <= t; caseno++)
            {
                string[] a = Console.ReadLine().Split(' ');
                len = a[0].Length;
                num = a[0].ToCharArray();
                rep = int.Parse(a[1]);
                StringBuilder ans = new StringBuilder("");

                for (int i = 0; i < len; i++)
                {
                    if (rep > 0 && num[i] != '9') {
                        ans.Append('9');
                        --rep;
                    }
                    else ans.Append(num[i]);
                }

                Console.WriteLine("Case {0}: {1}", caseno, ans.ToString());
            }
        }
    }
}
