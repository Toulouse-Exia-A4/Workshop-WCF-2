using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ServiceModel;
using System.Configuration;

namespace CAD
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost service = new ServiceHost(typeof(CAD_Implementation)))
            {
                service.Open();
                
                Console.WriteLine("Service started");
                Console.ReadLine();
            }

        }
    }
}
