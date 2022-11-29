using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Access_modifiers
{
    internal class Teacher:Human
    {
        public string Profession;

        public Teacher(string firstname, string surname, byte age, string gender, string profession):base(firstname,surname,age,gender)
        {
            Profession = profession;
        }
    }
}
