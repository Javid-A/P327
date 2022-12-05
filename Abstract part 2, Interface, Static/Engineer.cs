using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_part_2__Interface__Static
{
    internal class Engineer : Employee,IMentalable
    {
        public Engineer(string firstname, string surname, byte age, string gender):base(firstname,surname,age,gender)
        {

        }

        public byte IQ { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

      

        public override void Eat()
        {
            throw new NotImplementedException();
        }

   

        public override void Salary()
        {
            throw new NotImplementedException();
        }
    }
}
