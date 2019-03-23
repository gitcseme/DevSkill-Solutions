using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class CDP_22
    {
        static void Main()
        {
            char[] x = new char[50];
            x[0] = '0';
            x[1] = '1';
            x[2] = '2';
            x[3] = '3';
            x[4] = '4';
            x[5] = '5';
            x[6] = '6';
            x[7] = '7';
            x[8] = '8';
            x[9] = '9';
            x[10] = 'A';
            x[11] = 'B';
            x[12] = 'C';
            x[13] = 'D';
            x[14] = 'E';
            x[15] = 'F';
            x[16] = 'G';
            x[17] = 'H';
            x[18] = 'I';
            x[19] = 'J';
            x[20] = 'K';
            x[21] = 'L';
            x[22] = 'M';
            x[23] = 'N';
            x[24] = 'O';
            x[25] = 'P';
            x[26] = 'Q';
            x[27] = 'R';
            x[28] = 'S';
            x[29] = 'T';
            x[30] = 'U';
            x[31] = 'V';
            x[32] = 'W';
            x[33] = 'X';
            x[34] = 'Y';
            x[35] = 'Z';


            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string[] a = Console.ReadLine().Split(',');
                int num = int.Parse(a[0]);
                int b = int.Parse(a[1]);
                StringBuilder sb = new StringBuilder("");
                int rem;

                if (num == 0)
                {
                    Console.WriteLine("0");
                    continue;
                }

                while (num != 0)
                {
                    rem = num % b;
                    sb.Append(x[rem]);
                    num = num / b;
                }


                string s = sb.ToString();
                for (int i  = s.Length-1; i >= 0; --i)
                {
                    Console.Write(s[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
