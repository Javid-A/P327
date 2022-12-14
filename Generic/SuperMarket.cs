using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class SuperMarket<T,U>
    {
        public T[] basket;
        public U Total;

        public SuperMarket(T[] arr)
        {
            basket = arr;
            Total = default;
        }

    }
}
