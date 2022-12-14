using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class CustomList<T>
    {
        T[] _arr;

        public CustomList()
        {
            _arr = new T[0];
        }

        public void Add(T obj)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = obj;
        }

        public T[] GetDatas()
        {
            return _arr;
        }
    }
}
