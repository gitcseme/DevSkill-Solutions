using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_543
    {
        static void Main(string[] args)
        {
            //Console.SetIn(new StreamReader(@"../../inp.txt"));

            int len, N, t = int.Parse(Console.ReadLine());
            string s;
            int[] c = new int[30];

            while (t-- > 0)
            {
                for (int i = 0; i < 26; ++i) c[i] = -1;
                string[] a = Console.ReadLine().Split(' ');
                s = a[0];
                N = int.Parse(a[1]);
                len = s.Length;

                for (int i = 0; i < len; ++i) ++c[s[i] - 'a'];

                int dup = 0;
                for (int i = 0; i < 26; ++i) if (c[i] != -1) dup += c[i];
                if (dup <= N)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

    }
}
