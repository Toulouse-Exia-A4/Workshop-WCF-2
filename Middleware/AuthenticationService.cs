using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Middleware
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "AuthenticationService" à la fois dans le code et le fichier de configuration.
    public class AuthenticationService : IAuthenticationService
    {
        public bool Authenticate(string username, string password)
        {
            var client = new CADService.CAD_InterfaceClient();
            return client.Authenticate(username, password);
        }

        public bool CheckExistence(string username)
        {
            var client = new CADService.CAD_InterfaceClient();
            return client.CheckExistence(username);
        }
    }
}
