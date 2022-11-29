using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Access_modifiers
{
    //Student and Teacher - derived class
    //Human - base class
    internal class Human
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
    }
}
