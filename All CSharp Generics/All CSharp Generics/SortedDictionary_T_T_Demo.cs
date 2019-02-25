using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class SortedDictionary_T_T_Demo
    {
        private static int value;

        static void Main(string[] args)
        {
            // Using default compare for arrange key in ascending order
            SortedDictionary<int, int> sdic = new SortedDictionary<int, int>();
            sdic.Add(12, 5);
            sdic.Add(2, -5);
            sdic.Add(25, 2);
            sdic.Add(5, 1);
            sdic.Add(20, 15);
            sdic.Add(7, 20);
            foreach (var e in sdic)
            {
                Console.WriteLine("{0} : {1}", e.Key, e.Value);
            }
            Console.WriteLine("\n");

            // Using default compare for arrange key in descending order
            foreach (var e in sdic.Reverse())
            {
                Console.WriteLine("{0} : {1}", e.Key, e.Value);
            }
            Console.WriteLine("\n");

            // Using custom compare arrange in defined order
            SortedDictionary<int, int> csdic = new SortedDictionary<int, int>(new KeyComparer());
            csdic.Add(12, 5);
            csdic.Add(2, -5);
            csdic.Add(25, 2);
            csdic.Add(5, 1);
            csdic.Add(20, 15);
            csdic.Add(7, 20);
            foreach (var e in csdic)
            {
                Console.WriteLine("{0} : {1}", e.Key, e.Value);
            }
            Console.WriteLine("\n");

            // Check if key already exists
            if (sdic.ContainsKey(25))
            {
                Console.WriteLine("SortedDictionary contains key 25");
            }
            else
                Console.WriteLine("SortedDictionary doesn't contain key 25");
            Console.WriteLine("");

            // TryGetValue
            if (sdic.TryGetValue(55, out value))
            {
                Console.WriteLine("for key 55 value is : {0}", value);
            }
            else Console.WriteLine("key 55 is not specified.");
            Console.WriteLine();

            // Get the set of values
            SortedDictionary<int, int>.ValueCollection valueList = sdic.Values;
            foreach (var e in valueList)
            {
                Console.Write("{0} ", e);
            }
            Console.WriteLine("\n");

            // Get the key set
            var keys = sdic.Keys;
            foreach (var e in keys)
            {
                Console.Write("{0} ", e);
            }
            Console.WriteLine("\n");

            // Removing key from Sorted dictionary
            sdic.Remove(12);
            if (sdic.ContainsKey(12))
            {
                Console.WriteLine("Key 12 is not removed");
            }
            else Console.WriteLine("Key 12 is removed");
            Console.WriteLine();
        }

        public class KeyComparer : IComparer <int>
        {
            public int Compare(int a, int b)
            {
                if (even(a) && even(b))
                {
                    return a.CompareTo(b);
                }
                else if (!even(a) && !even(b))
                {
                    return a.CompareTo(b);
                }
                else
                {
                    if (even(a)) return 1;
                    return -1;
                }
            }

            private bool even(int a)
            {
                return (a % 2 == 0);
            }
        }

        
    }
}
