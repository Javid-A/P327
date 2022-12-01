using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_set_accessor__Abstract
{
    internal abstract class Employee:Human
    {
        public Employee(string firstname, string surname, byte age, string gender):base(firstname,surname,age,gender)
        {

        }

        public abstract void Salary();
    }
}
