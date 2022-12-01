using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_set_accessor__Abstract
{
    internal class Gun
    {
        public virtual void Reload()
        {
            for (int i = 1; i <= 30; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine($"{i}. Fire");
            }
        }
    }
}
