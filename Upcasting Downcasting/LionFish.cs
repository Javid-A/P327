using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting
{
    internal class LionFish : Fish
    {
        public string Poison;
        public override void Eat()
        {
            Console.WriteLine("Small fishes");
        }

        public override void Swim()
        {
            Console.WriteLine("Lionfish somehow swimming");
        }
    }
}
