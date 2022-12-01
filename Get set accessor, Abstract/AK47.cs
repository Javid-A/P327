using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_set_accessor__Abstract
{
    internal class AK47:Gun
    {
        public override void Reload()
        {
            for (int i = 1; i <= 35; i++)
            {
                Thread.Sleep(40);
                Console.WriteLine($"{i}. Fire");
            }
        }
    }
}
