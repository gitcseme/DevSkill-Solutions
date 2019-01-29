using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_194
    {
        static void Main ()
        {
            Dictionary<int, string> code = new Dictionary<int, string>();
            code[11] = "Citycell";
            code[15] = "Teletalk";
            code[16] = "Airtel";
            code[17] = "Grameenphone";
            code[18] = "Robi";
            code[19] = "Banglalink";

            int t = int.Parse(Console.ReadLine());
            string cell, sub;
            int start;
            while (t-- > 0)
            {
                cell = Console.ReadLine();
                if (cell.Length == 11)
                {
                    sub = cell.Substring(1, 2);
                    start = int.Parse(sub);
                    Console.WriteLine("88{0} {1}", cell, code[start]);
                }
                else
                {
                    sub = cell.Substring(3, 2);
                    start = int.Parse(sub);
                    Console.WriteLine("{0} {1}", cell, code[start]);
                }
            }
        }
    }
}
