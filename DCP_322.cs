using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_322
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            string f, s; 
            while (t-- > 0)
            {
                string[] a = Console.ReadLine().Split(' ');
                f = a[0];
                s = a[1];
                int len = f.Length;
                if (f == s)
                {
                    Console.WriteLine("Yes");
                    continue;
                }

                StringBuilder sb = new StringBuilder(f);
                char c;
                bool b = false;
                for (int i = 0; i < len-1; ++i)
                {
                    c = sb[0];
                    sb.Remove(0, 1);
                    sb.Append(c);
                    if (sb.ToString() == s)
                    {
                        b = true;
                        break;
                    }
                }
                if (b) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
            
        }
    }
}
