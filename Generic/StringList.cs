using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class StringList
    {
        string[] _arr;

        public StringList()
        {
            _arr = new string[0];
        }

        public void Add(string word)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = word;
        }

        public string[] GetDatas()
        {
            return _arr;
        }
    }
}
