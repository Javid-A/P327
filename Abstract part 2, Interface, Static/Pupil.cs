using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_part_2__Interface__Static
{
    internal class Pupil : Human
    {
        public Pupil(string firstname, string surname, byte age, string gender) : base(firstname, surname, age, gender)
        {

        }

       //Dummy code

        public override void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
