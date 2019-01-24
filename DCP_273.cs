using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_273
    {
        static void Main (string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string word = Console.ReadLine();
                int len = word.Length;
                bool easy = true;
                for (int i = 0; i < len; ++i)
                {
                    if (word[i] == 'r')
                    {
                        easy = false;
                        break;
                    }
                }
                if (easy) {
                    Console.WriteLine("Vely easy");
                }
                else {
                    Console.WriteLine("Not vely easy");
                }
            }
        }
    }
}
