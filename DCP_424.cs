using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    public class Node
    {
        public string s;
        public int unique, serial;
        public Node(string s, int unique, int serial)
        {
            this.s = s;
            this.unique = unique;
            this.serial = serial;
        }
    }

    class DCP_424
    {
        static void Main(string[] args)
        {
            //Console.SetIn(new StreamReader("../../inp.txt"));

            int t = int.Parse(Console.ReadLine());
            int n, i, u, min;
            string s;

            while (t-- > 0)
            {
                n = int.Parse(Console.ReadLine());
                i = 0;
                min = 100;
                List<Node> list = new List<Node>();
                while (n-- > 0)
                {
                    s = Console.ReadLine();
                    u = getUnique(s, s.Length);
                    list.Add(new Node(s, u, ++i));
                    min = Math.Min(min, u);
                }
                List<int> ans = new List<int>();
                foreach (var node in list)
                    if (node.unique == min) ans.Add(node.serial);

                ans.Sort();
                StringBuilder sb = new StringBuilder("");
                foreach (var e in ans) sb.Append(e + " ");
                Console.WriteLine(sb.ToString().Trim());
            }
        }

        private static int getUnique(string s, int len)
        {
            HashSet<char> hs = new HashSet<char>();
            for (int i = 0; i < len; i++) hs.Add(s[i]);
            return hs.Count;
        }
    }
}
