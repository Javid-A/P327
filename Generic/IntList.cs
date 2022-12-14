using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class IntList
    {
        int[] _arr;

        public IntList()
        {
            _arr = new int[0];
        }

        public void Add(int number)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = number;
        }

        public int[] GetDatas()
        {
            return _arr;
        }
    }
}
