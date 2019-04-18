using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_466
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            Dictionary<string, int> map = new Dictionary<string, int>();
            map.Add("Dhaka", 1);
            map.Add("Chittagong", 2);
            map.Add("Rajshahi", 3);
            map.Add("Kathmandu", 4);
            map.Add("Butwal", 5);

            while (q-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                int src = map[s[0]];
                int des = map[s[1]];
                int temp;
                if (src > des)
                {
                    temp = src;
                    src = des;
                    des = temp;
                }
                int sl = getLevel(src);
                int dl = getLevel(des);

                int ans = 0;

                if (src == des) Console.WriteLine("0");
                else if (sl == dl)
                {
                    if (src == 2) Console.WriteLine("500");
                    else Console.WriteLine("11000");
                }
                else if (sl == 0)
                {
                    if (dl == 1)
                    {
                        if (des == 3) Console.WriteLine("300");
                        else Console.WriteLine("200");
                    }
                    else // dl = 2
                    {
                        if (des == 4) Console.WriteLine("3200");
                        else Console.WriteLine("8200");
                    }
                }
                else if (sl == 1)
                {
                    if (src == 2)
                    {
                        if (des == 4) Console.WriteLine("3000");
                        else Console.WriteLine("8000");
                    }
                    else
                    {
                        if (des == 4) Console.WriteLine("3500");
                        else Console.WriteLine("8500");
                    }
                }
            }
        }

        private static int getLevel(int n)
        {
            if (n == 1) return 0;
            if (n == 2 || n == 3) return 1;
            return 2;
        }
    }
}
