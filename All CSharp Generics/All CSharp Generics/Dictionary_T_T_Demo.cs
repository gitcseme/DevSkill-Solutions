using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class Dictionary_T_T_Demo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> book = new Dictionary<int, string>();
            book.Add(2, "Introduction");
            book.Add(5, "Abstruct");
            book.Add(6, "Acknowledgements");
            book.Add(8, "Chapter 1");

            book[12] = "Chapter 2";

            foreach (KeyValuePair<int, string> item in book)
            {
                Console.WriteLine("key: {0}  value: {1}",item.Key, item.Value);
            }
            Console.WriteLine();

            // Key existency 
            if (book.ContainsKey(15))
                Console.WriteLine("15 exists as key");
            else
                Console.WriteLine("15 Does not exist as a key");
            Console.WriteLine();

            // value existency
            if (book.ContainsValue("Chapter 3"))
            {
                Console.WriteLine("Chapter 3 exist in book");
            }
            else
                Console.WriteLine("Chapter 3 does not exist in book");
            Console.WriteLine();

            // Getting values as collection
            Dictionary<int, string>.ValueCollection chapters = book.Values;
            foreach (string chapter in chapters)
            {
                Console.WriteLine(chapter);
            }
            Console.WriteLine();

            // Getting keys as collection
            Dictionary<int, string>.KeyCollection pageNumbers = book.Keys;
            foreach (int pageNumber in pageNumbers)
            {
                Console.WriteLine(pageNumber);
            }
            Console.WriteLine();

            // Remove key from dictionary
            book.Remove(12);
            if (book.ContainsKey(12))
            {
                Console.WriteLine("key 12 is not removed");
            }
            else
                Console.WriteLine("key 12 is removed");
            foreach (var item in book)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine();

            // Number of entries in dictionary
            Console.WriteLine("Number of entries in Dictionary:  {0}", book.Count);
        }
    }
}
