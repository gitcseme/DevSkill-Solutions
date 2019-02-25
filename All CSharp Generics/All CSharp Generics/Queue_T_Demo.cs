using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class Queue_T_Demo
    {
        static void Main(string[] args)
        {
            // A FIFO data structure. 
            Queue<string> q = new Queue<string>();
            q.Enqueue("Hasan");
            q.Enqueue("Shumon");
            q.Enqueue("Jalil");
            q.Enqueue("Rabbie");
            q.Enqueue("Prisor");

            Console.WriteLine("Size of Queue: {0}", q.Count); 

            int i = 1;
            while (q.Count > 0)
            {
                string s = q.Peek();
                q.Dequeue();
                Console.WriteLine("{0}: {1}", i, s);
                i++;
            }
            Console.WriteLine();

            // get an array representation of the queue
            Queue<int> q2 = new Queue<int>(new int[] { 5, 98, 4, 555, 47, 30 });
            int[] arr = new int[q2.Count];
            q2.CopyTo(arr, 0);
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write("{0} ", arr[j]);
            }
            Console.WriteLine("\n");
        }
    }
}
