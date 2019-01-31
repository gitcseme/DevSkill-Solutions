using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill_Problems
{
    class Student
    {
        public string name;
        public double cgpa;
        public Student (string s, double gpa)
        {
            name = s;
            cgpa = gpa;
        }
    }
    class DCP_193
    {
        static void Main ()
        {
            List<Student> list = new List<Student>();
            int t = int.Parse(Console.ReadLine());
            string name;
            double cgpa;
            while (t-- > 0)
            {
                string[] a = Console.ReadLine().Split(' ');
                name = a[0];
                cgpa = double.Parse(a[1]);
                list.Add(new Student(name, cgpa));
            }

            list.Sort((c1, c2) => {
                if (c1.cgpa == c2.cgpa)
                    return c1.name.CompareTo(c2.name);
                else
                    return -(c1.cgpa.CompareTo(c2.cgpa));
            });

            int n = 0;
            double prev = -1.0;
            foreach (var item in list)
            {
                if (item.cgpa != prev) ++n;
                Console.WriteLine("{0}.{1}", n, item.name);
                prev = item.cgpa;
            }
        }
    }
}
