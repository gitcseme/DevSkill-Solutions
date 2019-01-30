using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// never be so happy when you are happy and never be so sad when you are sad

namespace DevSkill_Problems
{
    class DCP_483
    {
        static void Main ()
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("never");
            set.Add("be");
            set.Add("so");
            set.Add("happy");
            set.Add("when");
            set.Add("you");
            set.Add("and");
            set.Add("sad");
            set.Add("are");

            string w;
            while ((w = Console.ReadLine()) != null)
            {
                if (set.Contains(w))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
