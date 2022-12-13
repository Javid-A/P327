using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting
{
    internal class Husky:Dog,IShavable
    {
        public string Fur;

        public override void Bark()
        {
            Console.WriteLine("Husky make sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Fish and chicken");
        }

        public void Shave()
        {
            Fur = $"{GetType().Name}'s fur is gone";
            Console.WriteLine(Fur);
        }
    }
}
