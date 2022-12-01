using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_set_accessor__Abstract
{
    internal class Teacher:Employee
    {
        public Teacher(string firstname, string surname, byte age, string gender) : base(firstname, surname, age, gender)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("Juicy Steak");
        }

        public override void Salary()
        {
            throw new NotImplementedException();
        }
    }
}
