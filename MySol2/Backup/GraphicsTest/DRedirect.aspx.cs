using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GraphicsTest
{
    public partial class DRedirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] == "1")
            {
                Response.Redirect(@"http://baidu.com");
            }
        }
    }
}