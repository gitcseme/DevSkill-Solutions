using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_problems
{
    class DCP_545
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(), Console.InputEncoding, false, bufferSize: 1024));

            int K, t = int.Parse(Console.ReadLine());
            int[] a = new int[110];

            while (t-- > 0)
            {
                K = int.Parse(Console.ReadLine());

                string[] arr = Console.ReadLine().Split();
                for (int i = 0; i < 100; i++) a[i] = int.Parse(arr[i]);

                int sum, mx = 100;
                for (int i = 0; i < 100; i++)
                {
                    sum = 0;
                    for (int j = i; j < 100; j++)
                    {
                        sum += a[j];
                        if (sum >= K)
                        {
                            mx = Math.Min(mx, j - i + 1);
                            break;
                        }
                    }
                }
                Console.WriteLine(mx);
            }
        }
    }
}
