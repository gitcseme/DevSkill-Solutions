using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_26
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            string s;

            while (t-- > 0)
            {
                s = Console.ReadLine();
                StringBuilder sb = new StringBuilder("");
                for (int i = s.Length - 1; i >= 0; --i)
                {
                    sb.Append(s[i]);
                }
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
