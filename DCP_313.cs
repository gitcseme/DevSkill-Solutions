using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_313
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            Dictionary<string, int> dp = new Dictionary<string, int>();
            dp.Add("Easy Problem", 20);
            dp.Add("Medium Problem", 40);
            dp.Add("Hard Problem", 68);

            while (t-- > 0)
            {
                string s = Console.ReadLine();
                Console.WriteLine(dp[s]);
            }
        }
    }
}
