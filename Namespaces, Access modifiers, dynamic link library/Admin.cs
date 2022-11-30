using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces__Access_modifiers__dynamic_link_library
{
    internal class Admin:User
    {
        public string Section;
        public bool IsSuperAdmin;


        public Admin(string username, string pw, string section, bool isSuperAdmin):base(username,pw)
        {
            Section = section;
            IsSuperAdmin = isSuperAdmin;
        }
        public void Info()
        {
            Console.WriteLine($"{Username}, {Password.GetHashCode()}, {Section}, {(IsSuperAdmin ? "Super admindir" : "Super admin deyil")} ");
        }
    }
}
