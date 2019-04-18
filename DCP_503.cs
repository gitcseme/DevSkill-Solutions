using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_503
    {
        static void Main(string[] args)
        {
            //Console.SetIn(new StreamReader("../../inp.txt"));

            int t = int.Parse(Console.ReadLine());
            int n, j;

            while (t-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                n = int.Parse(s[0]);
                j = int.Parse(s[1]);

                List<int> KE = new List<int>();
                List<int> DGM = new List<int>();
                int id = 0;
                string[] g = Console.ReadLine().Split(' ');
                for (int i = 0; i < n; i++)
                {
                    ++id;
                    int x = int.Parse(g[i]);
                    if (x > j) KE.Add(id);
                    else DGM.Add(id);
                }

                Console.WriteLine("Kache Eso");
                if (KE.Count == 0) Console.WriteLine();
                else
                {
                    StringBuilder ans = new StringBuilder();
                    foreach (int e in KE) ans.Append(e + " ");
                    Console.WriteLine(ans.ToString().TrimEnd());
                }

                Console.WriteLine("Dure Giya Mor");
                if (DGM.Count == 0) Console.WriteLine();
                else
                {
                    StringBuilder ans = new StringBuilder();
                    foreach (int e in DGM) ans.Append(e + " ");
                    Console.WriteLine(ans.ToString().TrimEnd());
                }

            }
        }
    }
}
