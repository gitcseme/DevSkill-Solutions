using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class SortedSet_T_Demo
    {
        static void Main(string[] args)
        {
            // SortedSet Maintain a default sorting order
            // Do not contain duplicate elements
            SortedSet<string> sset = new SortedSet<string>();
            sset.Add("Rollex");
            sset.Add("Zolla");
            sset.Add("Captain");
            sset.Add("Armory");
            sset.Add("Cobol");
            sset.Add("Cobol");
            sset.Add("Colon");

            display(sset);
            Console.WriteLine();

            // print in Reverse order
            foreach (var e in sset.Reverse())
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Remove a specific item
            sset.Remove("Cobol");
            
            // check existanse 
            if (sset.Contains("Cobol"))
                Console.WriteLine("Cobol is not removed");
            else
                Console.WriteLine("Cobol is removed");
            Console.WriteLine();

            // Remove the element starts with 'C' using delegate.
            Predicate<string> con = new Predicate<string>(comp);
            sset.RemoveWhere(con);

            display(sset);
            Console.WriteLine();

            // Remove all elements from the set
            sset.Clear();
            if (sset.Count == 0)
                Console.WriteLine("The set is empty");
            else
                Console.WriteLine("The set contains elements");
            Console.WriteLine();
        }

        static bool comp (string v)
        {
            if (v[0] == 'C')
                return true;
            else
                return false;
        }

        private static void display(SortedSet<string> sset)
        {
            foreach (var e in sset)
            {
                Console.WriteLine(e);
            }
        }
    }
}
