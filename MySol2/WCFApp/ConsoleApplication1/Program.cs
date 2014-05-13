using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host;
                host = new ServiceHost(typeof(WcfServiceLibrary1.Service1));
                host.Open();

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
