using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_part_2__Interface__Static
{
    internal class Category
    {
        public int Id;
        public string Name;
        public string Image;
        static int count;
        public Category(string name, string image)
        {
            Id = count;
            Name = name;
            Image = image;
            count++;
            
        }
        static Category()
        {
            count = 1;
        }

        public void NonStaticMethod()
        {
            Console.WriteLine(Name);
            Console.WriteLine(count);
        }

        public static void StaticMethod()
        {
            Console.WriteLine(count);
        }
    }
}
