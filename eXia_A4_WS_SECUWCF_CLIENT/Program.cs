﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using eXia_A4_WS_SECUWCF_CLIENT.ServerService;

namespace M0_CU
{
    static class Program
    {
        static void Main(string[] args)
        {
            ServiceClient client = new ServiceClient();
            bool authenticated = client.Authenticate("simon", "azerty");
            Console.WriteLine(authenticated);
            Console.ReadLine();
        }
    }
}