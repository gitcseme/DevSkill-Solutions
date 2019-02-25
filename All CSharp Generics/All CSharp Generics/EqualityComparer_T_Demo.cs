using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_CSharp_Generics
{
    class EqualityComparer_T_Demo
    {
        static Dictionary<Box, string> container = new Dictionary<Box, string>(new EqualBoxComparer());
        static List<Box> uniqueBoxes = new List<Box>();

        static void Main(string[] args)
        {
            Box box1 = new Box(8, 4, 8, "red");
            Box box2 = new Box(8, 6, 8, "orange");
            Box box3 = new Box(4, 8, 8, "yellow");
            Box box4 = new Box(8, 8, 4, "violate");

            AddBox(box1, box1.name);
            AddBox(box2, box2.name);
            AddBox(box3, box3.name);
            AddBox(box4, box4.name);

            Console.WriteLine("\nEnique dimension boxes are bellow");
            foreach (var item in uniqueBoxes)
            {
                Console.WriteLine(container[item]);
            }
        }

        public static void AddBox(Box b, string boxName)
        {
            try
            {
                container.Add(b, boxName);
                uniqueBoxes.Add(b);
            }
            catch (Exception)
            {
                Console.WriteLine("{0} already exists", b.name);
            }
        }

    }

    class Box
    {
        public int Height { get; set; }
        public int width { get; set; }
        public int Length { get; set; }
        public string name;
        public Box (int h, int w, int l, string n)
        {
            this.Height = h;
            this.width = w;
            this.Length = l;
            this.name = n;
        }
    }

    // This calss defines how the dictionary should check equality of two objects of type Box.
    class EqualBoxComparer : EqualityComparer<Box>
    {
        public override bool Equals(Box x, Box y)
        {
            if (x == null || y == null)
            {
                return false;
            }
            else if (x.Height * x.width * x.Length == y.Height * y.width * y.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Box obj)
        {
            int hashValue = obj.Height ^ obj.width ^ obj.Length;
            return hashValue;
        }
    }
}
