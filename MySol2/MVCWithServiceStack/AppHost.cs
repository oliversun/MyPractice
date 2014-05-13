using Funq;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.Logging;

using ServiceStack.Common.ServiceModel;
using ServiceStack.ServiceHost;
using ServiceStack.WebHost.Endpoints.Support;
using ServiceStack.WebHost.Endpoints;

namespace MVCWithServiceStack
{
    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("Tech.Pro ServiceStack Tutorial", typeof(AppHost).Assembly)
        {
        }

        public override void Configure(Container container) 
        {
            SetConfig(new EndpointHostConfig
            {
                //This is needed since you will be hosting your services from /api
                ServiceStackHandlerFactoryPath = "api"
            });
        }



    }
}