using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPPWithServiceStack
{
   
        [Route("/hello",Verbs="GET,POST")]
        [Route("/hello/{Name}",Verbs="GET,POST")]
        public class Hello
        {
            public string Name { get; set; }
        }
   
}