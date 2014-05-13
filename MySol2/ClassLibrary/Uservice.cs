using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web.Services;

namespace ClassLibrary
{
    [WebService(Namespace = "http://mysevice")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public partial class Uservice : System.Web.Services.WebService
    {

        [WebMethod]
        public string MyHello()
        {
            return "Hello Sunwei";
        }
    }
}
