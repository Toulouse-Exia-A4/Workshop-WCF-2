using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServerService;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceClient client = new ServiceClient();
            bool authenticated = client.Authenticate("simon", "aze");
            Console.WriteLine(authenticated);
            Console.ReadLine();
            
        }
    }
}
