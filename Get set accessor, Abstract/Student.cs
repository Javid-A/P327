using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_set_accessor__Abstract
{
    internal class Student:Human
    {
        public Student(string firstname, string surname, byte age, string gender):base(firstname,surname,age,gender)
        {
            
        }

        public override void Eat()
        {
            Console.WriteLine("Makaron");
        }
    }
}
