using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_set_accessor__Abstract
{
    internal class UZI:Gun
    {
        public string Skin;
        public override void Reload()
        {
            for (int i = 1; i <= 50; i++)
            {
                Thread.Sleep(20);
                Console.WriteLine($"{i}. Fire");
            }
        }
        public override string ToString()
        {
            return $"{Skin}";
        }
    }
}
