using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class Stack_T_Demo
    {
        static void Main(string[] args)
        {
            // Basic Last In First Out (LIFO) data structure is Stack<T>
            Stack<char> stk = new Stack<char>();
            stk.Push('H');
            stk.Push('E');
            stk.Push('L');
            stk.Push('L');
            stk.Push('O');

            // string HELLO is reversed using stack
            Console.Write("Reverse: ");
            while (stk.Count != 0)
            {
                char c = stk.Peek(); // Returns a read-only reference of the top element
                stk.Pop(); // removes the top element from stack.
                Console.Write(c);
            }
            Console.WriteLine("\n");

            Stack<int> numbers = new Stack<int>(new int[] { 5, 4, 3, 2, 1 });

            // We get same result as avobe by enumerating the stack 
            Console.Write("Reversed order: ");
            foreach (var e in numbers)
            {
                Console.Write("{0} ", e);
            }
            Console.WriteLine("\n");

            // Size of the stack
            Console.WriteLine("size is: {0}", numbers.Count);
            Console.WriteLine();

            // Remove all the elements from stack
            numbers.Clear();
            Console.WriteLine("size is: {0}", numbers.Count);
            Console.WriteLine();

            // check if element exists.
            Stack<int> numbers2 = new Stack<int>(new int[] { 50, 40, 33, 22, 15, 17, 10 });
            if (numbers2.Contains(17))
                Console.WriteLine("17 exists");
            else
                Console.WriteLine("17 does not exists");
            Console.WriteLine();

            if (numbers2.Contains(99999))
                Console.WriteLine("99999 exists");
            else
                Console.WriteLine("99999 does not exists");
            Console.WriteLine();
        }
    }
}
