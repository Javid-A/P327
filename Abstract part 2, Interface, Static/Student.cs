using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_part_2__Interface__Static
{
    internal class Student
    {
        public string Firstname;
        public string Surname;
        public Group Group;

        public Student(string firstname, string surname)
        {
            Firstname = firstname;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Firstname} {Surname} {Group?.No}({Group?.Limit})";
        }
    }
}
