using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_584
    {
        static void Main ()
        {
            int t = int.Parse(Console.ReadLine());
            int vowel, consonant, totalChange;
            while (t-- > 0)
            {
                vowel = 0;
                consonant = 0;
                totalChange = 0;

                char[] c = Console.ReadLine().ToCharArray();
                int len = c.Length;

                for (int i = 0; i < len; i++)
                {
                    if (c[i] >= 97 && c[i] <= 122)
                    {
                        if (isVowel(c[i])) ++vowel;
                        else ++consonant;
                    }
                    else
                        ++totalChange;
                }
                if (vowel > consonant) totalChange += consonant;
                else totalChange += vowel;

                Console.WriteLine(totalChange);
            }
        }

        private static bool isVowel(char v)
        {
            if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
                return true;
            return false;
        }
    }
}
