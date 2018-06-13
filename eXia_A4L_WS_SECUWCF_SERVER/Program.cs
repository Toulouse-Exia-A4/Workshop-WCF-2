using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using System.Web.Services.Description;
using System.ServiceModel;
using System.ServiceModel.Description;
using eXia_A4L_WS_SECUWCF_SERVER.MiddlewareService;

namespace M0_SVR
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        bool Authenticate(string username, string password);
    }

    public class Service : IService
    {
        public bool Authenticate(string username, string password)
        {
            var middlewareService = new AuthenticationServiceClient();
            middlewareService.ClientCredentials.Windows.ClientCredential.UserName = "middlewareuser";
            middlewareService.ClientCredentials.Windows.ClientCredential.Password = "password";
            if (middlewareService.CheckExistence(username))
                return middlewareService.Authenticate(username, password);

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //host = new WebServiceHost(typeof(Service));
            using (ServiceHost host = new ServiceHost(typeof(Service)))
            {
                host.Open();
                Console.WriteLine("Press <ENTER> to terminate");
                Console.ReadLine();
                host.Close();
            }
            
        }
        
    }
}
