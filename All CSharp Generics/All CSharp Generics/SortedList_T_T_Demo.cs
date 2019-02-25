using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class SortedList_T_T_Demo
    {
        static void Main(string[] args)
        {
            SortedList<string, int> sList = new SortedList<string, int>(new StringLengthComparer());
            sList.Add("Zero", 0);
            sList.Add("One", 100);
            sList.Add("Two", 1);
            sList.Add("Sixty Five", 65);
            sList.Add("Three", 6666);
            sList.Add("Four", 99999);
            sList.Add("Eight", 1000000);
            sList.Add("X", 55555);

            Display(sList);
            Console.WriteLine();

            // Check key existency
            if (sList.ContainsKey("X"))
                Console.WriteLine("Key exists, entry is X: {0}", sList["X"]);
            else
                Console.WriteLine("Key doesn't exist");
            Console.WriteLine();

            // Get the Key set
            IList<string> sListKeys = sList.Keys;
            Console.Write("Keys in List: ");
            foreach (string e in sListKeys)
            {
                Console.Write("{0} ", e);
            }
            Console.WriteLine("\n");

            // Get the Value set
            IList<int> sListValues = sList.Values;
            Console.Write("Values in List: ");
            foreach (int e in sListValues)
            {
                Console.Write("{0} ", e);
            }
            Console.WriteLine("\n");

            // Remove an entry 
            sList.Remove("X");
            if (sList.ContainsKey("X"))
                Console.WriteLine("Key X is not removed");
            else
                Console.WriteLine("Key X is removed");
            Console.WriteLine();
        }

        // Compair strings by Length 
        class StringLengthComparer : IComparer<string>
        {
            // [note : this method can't return 0, Because 2 elements can't be unique]
            public int Compare(string x, string y)
            {
                if (x.Length == y.Length)
                {
                    return x.CompareTo(y);
                }
                return x.Length.CompareTo(y.Length);
            }
        }

        private static void Display(SortedList<string, int> sList)
        {
            foreach (var e in sList)
            {
                Console.WriteLine("{0} : {1}", e.Key, e.Value);
            }
        }
    }
}
