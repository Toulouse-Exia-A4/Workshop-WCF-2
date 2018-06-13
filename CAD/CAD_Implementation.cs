using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    class CAD_Implementation : CAD_Interface
    {
        public bool Authenticate(string username, string password)
        {
            return username == "toto" && password == "toto123";
        }

        public bool CheckExistence(string username)
        {
            return username == "toto";
        }
    }
}
