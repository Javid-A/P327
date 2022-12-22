using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception__Reflection
{
    internal class Student
    {
        public byte Age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender;
        string PrivateField = "Default private value";

        public Student(byte age)
        {
            Age = age;
        }

        public void CheckAge()
        {
            if (Age > 18)
            {
                Console.WriteLine("Everything is okay");
            }
            else
            {
                throw new StudentAgeOutOfRangeException("This is custom message");
            }
        }
    }
}
