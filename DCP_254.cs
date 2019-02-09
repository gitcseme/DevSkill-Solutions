using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_254
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int[] rate = new int[] { 1, 3, 10, -5 };
            int max = int.MinValue;

            for (int player = 1; player <= p; player++)
            {
                int score = 0;
                string[] bols = Console.ReadLine().Split(' ');
                for (int i = 0; i < 4; i++)
                {
                    score += (int.Parse(bols[i]) * rate[i]);
                }

                max = Math.Max(max, score);
                if (score < 0) score = 0;

                Console.WriteLine("Player {0}: {1}", player, score);
            }
            Console.WriteLine("High Score = {0}", max);
        }
    }
}
