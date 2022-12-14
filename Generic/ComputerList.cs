using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class ComputerList
    {
        Computer[] _arr;

        public ComputerList()
        {
            _arr = new Computer[0];
        }

        public void Add(Computer computer)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = computer;
        }

        public Computer[] GetDatas()
        {
            return _arr;
        }
    }
}
