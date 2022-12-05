using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_part_2__Interface__Static
{
    internal class Teacher : Employee, IMentalable
    {
        public Teacher(string firstname, string surname, byte age, string gender) : base(firstname, surname, age, gender)
        {

        }

        public byte IQ
        {
            get
            {
                return _iq;
            }
            set
            {
                if (value > 105)
                {
                    _iq = value;
                }
            }
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
