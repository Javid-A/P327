using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_set_accessor__Abstract
{
    internal class User
    {
        readonly int Id;
        public string Username { get; }
        public string Password { set { } }
        public const int Data = 1;

        public User()
        {
            Username = "test";
            Id = 1;
        }

        //void SetUsername()
        //{
        //    Username = "test"; seti olmadigi ucun sadece constructor daxilinde set oluna biler
        //    Id = 1; readonly formatina gore error verir
        //}
    }
}
