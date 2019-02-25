using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class Comparer_T_Class_Demo
    {
        static void Main(string[] args)
        {
            // Employee emplements IComparable Interface.
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 10, Name = "Ashfaq" });
            empList.Add(new Employee() { ID = 7, Name = "Rafiq" });
            empList.Add(new Employee() { ID = 13, Name = "Shafiq" });
            empList.Sort();

            IEnumerator en = empList.GetEnumerator();
            while (en.MoveNext())
            {
                Console.WriteLine("{0} : {1}", ((Employee)en.Current).ID, ((Employee)en.Current).Name);
            }
            Console.WriteLine();

            // Member sorting using MemberComparer class
            List<Member> memList = new List<Member>();
            memList.Add(new Member() { ID = 10, Name = "Ashfaq" });
            memList.Add(new Member() { ID = 7, Name = "Rafiq" });
            memList.Add(new Member() { ID = 13, Name = "Shafiq" });
            memList.Sort(new MemberComparer());

            foreach (var m in memList)
            {
                Console.WriteLine("{0} : {1}", m.ID, m.Name);
            }

        }
    }

    class Employee : IComparable<Employee>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CompareTo(Employee other)
        {
            return this.ID.CompareTo(other.ID);
        }
    }

    class Member // Suppose this class can't be modified.
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class MemberComparer : Comparer<Member>
    {
        public override int Compare(Member x, Member y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }
}
