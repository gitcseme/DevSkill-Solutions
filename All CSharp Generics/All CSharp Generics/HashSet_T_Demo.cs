using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class HashSet_T_Demo
    {
        static void Main(string[] args)
        {
            // Set contains unique elements removes duplicates
            HashSet<int> hs = new HashSet<int>();
            hs.Add(2);
            hs.Add(3);
            hs.Add(2);
            hs.Add(5);
            hs.Add(3);
            foreach (int e in hs)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // set union operation
            HashSet<int> even = new HashSet<int>();
            even.Add(2);
            even.Add(6);
            even.Add(10);
            HashSet<int> odd = new HashSet<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(7);
            odd.Add(10);
            odd.Add(6);

            HashSet<int> oddeven = new HashSet<int>(even);
            oddeven.UnionWith(odd);
            foreach (int e in oddeven)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            //set intersection (common elements between 2 sets)
            HashSet<int> s1 = new HashSet<int>();
            s1.Add(1);
            s1.Add(2);
            s1.Add(3);
            s1.Add(4);
            HashSet<int> s2 = new HashSet<int>();
            s2.Add(100);
            s2.Add(2);
            s2.Add(300);
            s2.Add(4);

            HashSet<int> intersection = new HashSet<int>(s1);
            intersection.IntersectWith(s2);
            foreach (int e in intersection)
            {
                Console.WriteLine(e);
            }
        }
    }
}
