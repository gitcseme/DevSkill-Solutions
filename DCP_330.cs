using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_330
    {
        static void Main(string[] args)
        {
            //Console.SetIn(new StreamReader("../../inp.txt"));

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int x = int.Parse(Console.ReadLine());
                bool sign = x % 2 == 0 ? true : false;

                double product = x * Math.Log10(2);
                double front = product - (int)(product);

                double now = Math.Pow(10, front);

                if (sign) Console.Write("+");
                else Console.Write("-");
                Console.WriteLine(now.ToString()[0]);
            }
        }
    }
}
