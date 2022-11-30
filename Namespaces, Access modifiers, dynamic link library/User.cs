using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces__Access_modifiers__dynamic_link_library
{
    internal class User
    {
        string _username;
        string _password;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }
            }
        }

        public User(string username, string pw)
        {
            Username = username;
            Password = pw;
        }


        public bool CheckPassword(string pw)
        {
            bool result = false;
            if (pw.Length >= 8)
            {
                bool hasDigit = false;
                bool hasLower = false;
                bool hasUpper = false;
                foreach (char character in pw)
                {
                    if (char.IsDigit(character))
                    {
                        hasDigit = true;
                    }else if (char.IsLower(character))
                    {
                        hasLower = true;
                    }
                    else if(char.IsUpper(character))
                    {
                        hasUpper = true;
                    }
                }
                result = hasLower && hasDigit && hasUpper;
                return result;
            }
            else
            {
                return result;
            }
        }
    }
}
