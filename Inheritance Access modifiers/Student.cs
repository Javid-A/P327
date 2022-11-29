using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Access_modifiers
{
    internal class Student : Human
    {
        public byte Grade;
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length > 3)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Please enter valid password");
                }
            }
        }

        public Student(string firstname, string surname, byte age, string gender, string password, byte grade) : base(firstname, surname, age, gender)
        {
            Grade = grade;
            Password = password;
        }

        //public string GetPassword()
        //{
        //    return _password;
        //}

        //public void SetPassword(string pw)
        //{
        //    if (pw.Length > 3)
        //    {
        //        _password = pw;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Minimum character count is 3");
        //    }
        //}

    }
}
