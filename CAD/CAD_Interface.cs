using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CAD
{
    [ServiceContract]
    interface CAD_Interface
    {
        [OperationContract]
        bool Authenticate(string username, string password);

        [OperationContract]
        bool CheckExistence(string username);
    }
}
