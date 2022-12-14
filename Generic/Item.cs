using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Item<T/*, U*/> where T : Electronics, ISensorable/* where U : class*/
    {
        #region Worst syntax
        //public byte Quality;
        //public string quality;
        //public char _quality;
        //public Item(byte quality)
        //{
        //    Quality = quality;
        //}
        //public Item(string quality)
        //{
        //    this.quality = quality;
        //}
        //public Item(char quality)
        //{
        //    _quality = quality;
        //} 
        #endregion

        public T Quality;

        public Item(T quality)
        {
            Quality = quality;
        }
    }
}
