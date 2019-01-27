using System;

namespace DevSkill_Problems
{
    class DCP_117
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                ulong n = ulong.Parse(Console.ReadLine());
                Console.WriteLine((n * (n + 1)) / 2);
            }
        }
    }
}
