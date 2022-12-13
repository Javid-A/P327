using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting
{
    internal class Chihuahua : Dog,IShavable
    {
        public string Fur;
        public override void Bark()
        {
            Console.WriteLine("Chihuahua make sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Nothing");
        }

        public void Shave()
        {
            Fur = $"{GetType().Name}'s fur is gone";
            Console.WriteLine(Fur);
        }
    }
}
