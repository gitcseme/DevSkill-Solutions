using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_2
    {
        static void Main(string[] args)
        {
            bool init = false;
            string line;
            ulong E, EK, P = 1;
            int N;

            while (true)
            {
                if (init)
                {
                    line = Console.ReadLine();
                    if (line == null) break;
                }
                init = true;
                if ((line = Console.ReadLine()) == null) break;

                E = ulong.Parse(line);
                N = int.Parse(Console.ReadLine());
                bool first = true;

                List<ulong> keys = new List<ulong>();
                for (int i = 0; i < N; i++)
                {
                    EK = ulong.Parse(Console.ReadLine());
                    keys.Add(EK);
                    if (first)
                    {
                        P = EK;
                        first = false;
                        continue;
                    }
                    P = gcd(P, EK);
                }

                foreach (ulong ek in keys)
                {
                    E = E - (ek / P);
                }
                Console.WriteLine("Output: {0}", E);
            }

        }

        private static ulong gcd(ulong a, ulong b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
    }
}
