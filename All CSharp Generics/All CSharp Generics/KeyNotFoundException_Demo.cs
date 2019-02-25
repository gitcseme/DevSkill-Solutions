using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class KeyNotFoundException_Demo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> map = new Dictionary<int, string>();
            map.Add(2, "Sunday");
            map.Add(7, "Friday");
            map.Add(1, "Monday");
            map.Add(4, "Monday");

            for (int i = 1; i <= 7; i++)
            {
                string day;
                try
                {
                    day = map[i] + " found";
                }
                catch (KeyNotFoundException ex)
                {
                    day = "Key is not in map";
                }

                Console.WriteLine(day);
            }

        }
    }
}
