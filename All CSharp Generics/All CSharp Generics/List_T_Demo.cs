using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class List_T_Demo
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                numbers.Add(i * 5);
            }
            display(numbers);
            Console.WriteLine();

            // check existency
            if (numbers.Contains(25))
                Console.WriteLine("List contains 25");
            else
                Console.WriteLine("List Does not contains 25");
            Console.WriteLine();

            // Remove specific index element
            numbers.RemoveAt(3);
            display(numbers);
            Console.WriteLine();

            // remove specific element
            numbers.Remove(10);
            display(numbers);
            Console.WriteLine();

            // sort elemets in a list
            List<int> lst = new List<int>();
            lst.Add(5);
            lst.Add(50);
            lst.Add(15);
            lst.Add(55);
            lst.Add(0);
            lst.Add(2);

            lst.Sort();
            display(lst);
            Console.WriteLine();

            // build an array from list
            int[] arr = lst.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine("\n");

            // sorting a List of object
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Arif", age = 20 });
            people.Add(new Person() { Name = "Mahin", age = 19 });
            people.Add(new Person() { Name = "Arif", age = 15 });
            people.Add(new Person() { Name = "Shuvo", age = 19 });
            people.Add(new Person() { Name = "Sifat", age = 12 });

            // Sort objects using Comparison delegate.
            Comparison<Person> del = new Comparison<Person>(Comp);
            people.Sort(del);

            foreach (var e in people)
            {
                Console.WriteLine("{0} , {1}", e.Name, e.age);
            }

        }

        private static int Comp(Person x, Person y)
        {
            if (x.age == y.age)
                return x.Name.CompareTo(y.Name);
            else
                return x.age.CompareTo(y.age);
        }

        public class Person
        {
            public string Name { get; set; }
            public int age { get; set; }
        } 

        private static void display(List<int> numbers)
        {
            foreach (var e in numbers)
            {
                Console.Write("{0} ", e);
            }
            Console.WriteLine();
        }
    }
}
