using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_part_2__Interface__Static
{
    internal abstract class Human
    {
        public string Firstname;
        public string Surname;
        public byte Age;
        public string Gender;

     

        public Human(string firstname, string surname, byte age, string gender)
        {
            Firstname = firstname;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        public void Fullname()
        {
            Console.WriteLine($"{Firstname} {Surname}");
        }

        public abstract void Eat();
    }
}
