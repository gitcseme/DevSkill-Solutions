using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class DCP_544
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string str = Console.ReadLine();
                if (str[0] == 'Q')
                    Console.WriteLine("I am going to ask you this one time, where is Gamora?");
                else if (str[0] == 'S')
                    Console.WriteLine("I will do you one better, who is Gamora?");
                else if (str[0] == 'D')
                    Console.WriteLine("I will do you one better, why is Gamora?");
                else
                    Console.WriteLine("What is Gamora?");
            }
        }
    }
}
