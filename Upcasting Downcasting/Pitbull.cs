using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting
{
    internal class Pitbull : Dog
    {
        public override void Bark()
        {
            Console.WriteLine("Pitbul make sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Cats");
        }
    }
}
