using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ConsoleAppHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost MyHost = null;
            MyHost = new ServiceHost(typeof(ServiceLibrary.Service1));
            MyHost.Open();

            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
