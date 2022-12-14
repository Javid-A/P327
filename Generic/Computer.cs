using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Computer:Electronics, ISensorable
    {
        public string Brand;
        public string Ram;
        public string Memory;

        public Computer(string brand, string ram, string memory)
        {
            Brand = brand;
            Ram = ram;
            Memory = memory;
        }

        public void Sensor()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Brand;
        }
    }
}
