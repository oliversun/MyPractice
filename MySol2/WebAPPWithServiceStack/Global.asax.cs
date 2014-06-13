using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebAPPWithServiceStack
{
    public class Global : System.Web.HttpApplication
    {
        public class AppHost : AppHostBase
        {
            //Tell Service Stack the name of your application and where to find your web services
            public AppHost() : base("Hello Web Services", typeof(HelloService).Assembly) { }

            public override void Configure(Funq.Container container)
            {
                //register any dependencies your services use, e.g:
                //container.Register<ICacheClient>(new MemoryCacheClient());
                // Host settings
                ServiceStack.Text.JsConfig.EmitCamelCaseNames = false;
                Feature disableFeatures = Feature.Jsv | Feature.Soap | Feature.Csv | Feature.Xml;
                SetConfig(new HostConfig (){ 
                
                    DefaultContentType="application/json",
                    EnableFeatures=Feature.All.Remove(disableFeatures),
#if DEBUG
                    DebugMode=true
#endif
               
                });
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            new AppHost().Init();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}