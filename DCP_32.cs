using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    public class Node
    {
        public int x, y, level;
        public bool vis;
        public Node(int xx, int yy)
        {
            x = xx;
            y = yy;
            vis = false;
        }
    }

    class DCP_32
    {
        static int[,] grid = new int[105, 105];
        static int[] X = new int[] { 0, -1, 0, 1 };
        static int[] Y = new int[] { -1, 0, 1, 0 };
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());

            for (int caseno = 1; caseno <= t; caseno++)
            {
                string[] a = Console.ReadLine().Split(' ');
                int x1 = int.Parse(a[0]);
                int y1 = int.Parse(a[1]);
                int x2 = int.Parse(a[2]);
                int y2 = int.Parse(a[3]);
                
                for (int i = 0; i < 102; i++)
                    for (int j = 0; j < 102; j++)
                        grid[i, j] = 0;

                int ans =  bfs(x1, y1, x2, y2);
                Console.WriteLine("Case {0}: {1}", caseno, ans);
            }
        }

        static int bfs(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2 && y1 == y2) return 0;

            Queue<Node> q = new Queue<Node>();
            Node src = new Node(x1, y1);
            src.vis = true;
            src.level = 0;
            q.Enqueue(src);

            int ret = 0;

            while (q.Count != 0)
            {
                Node u = q.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    if (isValid(u.x + X[i], u.y + Y[i]) && grid[u.x + X[i], u.y + Y[i]] == 0)
                    {
                        Node v = new Node(u.x + X[i], u.y + Y[i]);
                        v.level = u.level + 1;
                        v.vis = true;
                        grid[v.x, v.y] = 1;
                        q.Enqueue(v);
                        if (v.x == x2 && v.y == y2)
                        {
                            ret =  v.level;
                            goto END;
                        }
                    }
                } 
            }
            END:
            return ret;
        }

        private static bool isValid(int r, int c)
        {
            if (r < 0 || r > 100 || c < 0 || c > 100) 
                return false;
            return true;
        }
    }
}
