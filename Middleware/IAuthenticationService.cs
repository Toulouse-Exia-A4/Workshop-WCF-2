using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Middleware
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        bool Authenticate(string username, string password);

        [OperationContract]
        bool CheckExistence(string username);
    }
}
