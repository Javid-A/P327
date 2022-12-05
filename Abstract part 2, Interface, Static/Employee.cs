using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_part_2__Interface__Static
{
    internal abstract class Employee : Human
    {
        public string Spec1;
        public string Spec2;
        public string Spec3;
        public string Spec4;
        protected byte _iq;
        public Employee(string firstname, string surname, byte age, string gender) : base(firstname, surname, age, gender)
        {

        }
        public abstract void Salary();
    }
}
