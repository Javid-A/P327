using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces__Access_modifiers__dynamic_link_library
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool IsGraduated;

        public Student(string name, string surname, string group, byte point, bool isGraduated=false)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = isGraduated;
            Product product = new Product();
        }

        public string Fullname()
        {
            return $"{Name} {Surname}";
        }
        public void Info()
        {
            //if (IsGraduated)
            //{
            //    Console.WriteLine($"{Name} {Surname}, {Group}, {Point}, Mezun olub");
            //}
            //else
            //{
            //    Console.WriteLine($"{Name} {Surname}, {Group}, {Point}, Mezun olmayib");
            //}

            Console.WriteLine($"{Name} {Surname}, {Group}, {Point}, {(IsGraduated ? "Mezun olub" : "Mezun olmayib")}");
        }

        public void TryExam()
        {
            //if (Point > 80 && Point<100)
            //{
            //    Console.WriteLine("Imtahana gire biler");
            //}
            //else
            //{
            //    Console.WriteLine("Imtahana gire bilmez");
            //}
            Console.WriteLine($"{(Point > 80 && Point<100? "Imtahana gire biler" : "Imtahana gire bilmez")}");
        }
    }
}
