using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception__Reflection
{
    internal class StudentAgeOutOfRangeException:Exception
    {
        public StudentAgeOutOfRangeException()
        {
            Console.WriteLine("Student age out of range");
        }

        public StudentAgeOutOfRangeException(string message):base(message)
        {

        }
    }
}
