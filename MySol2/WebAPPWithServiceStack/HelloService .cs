using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPPWithServiceStack
{
    public class HelloService : Service
    {
        public object post(Hello request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
    } 
}