using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication2.MyWCFService;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWCFService.Service1Client client = new MyWCFService.Service1Client();
            User myUser = client.GetUser(123);
            Console.WriteLine(myUser.UserName);
            Console.WriteLine(client.SayHello(123));

            Console.Read();

        }
    }
}
