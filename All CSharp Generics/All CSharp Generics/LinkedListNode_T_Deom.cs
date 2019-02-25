using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class LinkedListNode_T_Deom
    {
        static void Main(string[] args)
        {
            LinkedListNode<int> newNode = new LinkedListNode<int>(100);
            Console.WriteLine("Current value in node: {0}", newNode.Value);
            Console.WriteLine();

            // change the value in node;
            newNode.Value = 500;
            Console.WriteLine("New value in node: {0}", newNode.Value);
            Console.WriteLine();

            // Create a linkedList
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(newNode);
            displayProperties(newNode);
            Console.WriteLine();

            // Adding nodes in list
            ll.AddFirst(999);
            ll.AddLast(777);
            displayProperties(newNode);
            Console.WriteLine();
        }

        private static void displayProperties(LinkedListNode<int> node)
        {
            Console.WriteLine("Node value: {0}", node.Value);
            if (node.Previous == null)
                Console.WriteLine("Previous node is null");
            else
                Console.WriteLine("Previous node is: {0}", node.Previous.Value);
            if (node.Next == null)
                Console.WriteLine("Next node is null");
            else
                Console.WriteLine("Next node is: {0}", node.Next.Value);
        }
    }
}
