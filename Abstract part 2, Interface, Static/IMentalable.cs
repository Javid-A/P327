using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_part_2__Interface__Static
{
    internal interface IMentalable
    {
        byte IQ { get; set; }

        byte Test()
        {
            return 5;
        }
    }
}
