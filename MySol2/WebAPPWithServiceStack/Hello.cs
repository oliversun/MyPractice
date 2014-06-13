using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPPWithServiceStack
{
        [Api("Get a hello")]
        [Route("/hello","GET,OPTIONS")]
        [Route("/hello/{Name}","GET,OPTIONS")]
        public class Hello:IReturn<HelloResponse>
        {
            public string Name { get; set; }
        }
   
}