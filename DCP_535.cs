using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_535
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int sum = 0;
                char[] c = Console.ReadLine().ToCharArray();
                int len = c.Length;

                for (int i = 0; i < len; ++i) sum = sum + c[i];
                if (sum % 20 == 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");

            }
        }
    }
}
