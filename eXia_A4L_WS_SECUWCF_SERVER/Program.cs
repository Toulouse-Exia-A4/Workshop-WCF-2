using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using System.Web.Services.Description;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace M0_SVR
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebInvoke]
        bool Authenticate(string username, string password);
    }

    public class Service : IService
    {
        public bool Authenticate(string username, string password)
        {
            return true;
        }
    }

    class Program
    {
        public static WebServiceHost host;

        static void Main(string[] args)
        {
            host = new WebServiceHost(typeof(Service), new Uri("http://localhost:30111/"));

            try
            {
                ServiceEndpoint ep = host.AddServiceEndpoint(typeof(IService), new WebHttpBinding(), "");
                host.Open();
                Console.WriteLine("Press <ENTER> to terminate");
                Console.ReadLine();
                host.Close();
            }
            catch (CommunicationException cex)
            {
                Console.WriteLine("An exception occured: {}", cex.Message);
                host.Abort();
            }
        }


    }
}
