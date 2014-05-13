using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp1.ServiceReference1;

namespace WebApp1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.UserviceSoapClient clinet = new UserviceSoapClient("UserviceSoap");
            Response.Write( clinet.MyHello());
            clinet.Close();
        }
    }
}