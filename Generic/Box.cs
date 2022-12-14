using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Box<T> where T:Electronics
    {
        public T electronic;


        public Box(T electronic)
        {
            this.electronic = electronic;
        }
        public void Safety()
        {
            if (electronic.Resolution > 5)
            {
                Console.WriteLine("unsafe");
            }
            else
            {
                Console.WriteLine("safe");
            }
        }
    }
}
