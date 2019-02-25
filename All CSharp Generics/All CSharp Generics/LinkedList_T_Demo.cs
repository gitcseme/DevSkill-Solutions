using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class LinkedList_T_Demo
    {
        static void Main(string[] args)
        {
            string[] words = { "the", "fox", "jumps", "over", "the", "dog" };
            LinkedList<string> list = new LinkedList<string>(words);
            DisplayList(list);
            Console.WriteLine();

            if (list.Contains("Tiger"))
                Console.WriteLine("Tiger is in list");
            else
                Console.WriteLine("Tiger is not in list");
            Console.WriteLine();

            // Add an item to the beginning of the list
            list.AddFirst("First_Item");
            //Add an item to the end of the list
            list.AddLast("Last_Item");
            DisplayList(list);
            Console.WriteLine();

            // Remove the first item
            list.RemoveFirst();
            // Remove the last item
            list.RemoveLast();
            DisplayList(list);
            Console.WriteLine();

            // Remove random node from list.
            list.Remove("jumps");
            DisplayList(list);
            Console.WriteLine();

            // Copy the list to an array
            string[] array = new string[list.Count];
            list.CopyTo(array, 0);
            foreach (string e in array)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Remove all the items from list
            list.Clear();
            Console.WriteLine(list.Count);

        }

        private static void DisplayList(LinkedList<string> list)
        {
            foreach (var e in list)
            {
                Console.Write("{0} ", e);
            }
            Console.WriteLine();
        }
    }
}
