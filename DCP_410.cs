using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_410
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int N;
            int[] Letters = new int[26];

            while(t-- > 0)
            {
                N = int.Parse(Console.ReadLine());
                char[] c = new char[N];
                c = Console.ReadLine().ToCharArray();
                for (int i = 0; i < 26; ++i) Letters[i] = 0;

                for (int i = 0; i < N; i++) ++Letters[(c[i] - 'a')];

                int maxLatter = 0;
                for (int i = 0; i < 26; ++i)
                    if (maxLatter < Letters[i])
                        maxLatter = Letters[i];

                Console.WriteLine(N-maxLatter);
            }
        }
    }
}
