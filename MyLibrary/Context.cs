using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Context
    {
        protected int Id;
        internal string InternalMember;
        protected internal string ProtectedInternalMember;
        private protected string PrivateProtectedMember;
    }
}
