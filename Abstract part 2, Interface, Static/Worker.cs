using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_part_2__Interface__Static
{
    internal class Worker : Employee
    {
        public Worker(string firstname, string surname, byte age, string gender) : base(firstname, surname, age, gender)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("Something");
        }

        public override void Salary()
        {
            Console.WriteLine("400");
        }
    }
}
