using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_476
    {
        static void Main ()
        {
            Dictionary<string, string> verdict = new Dictionary<string, string>();
            verdict["ac"] = "Accepted";
            verdict["wa"] = "Wrong Answer";
            verdict["rte"] = "Run Time Error";
            verdict["tle"] = "Time Limit Exceeded";

            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string v = Console.ReadLine();
                Console.WriteLine(verdict[v]);
            }
        }
    }
}
