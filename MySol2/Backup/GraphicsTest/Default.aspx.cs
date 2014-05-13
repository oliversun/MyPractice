using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GraphicsTest.App_Code;
using System.IO;

namespace GraphicsTest
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            //保存为Jpg类型  
            WaterImageManage.DrawWords("", "酒店价格：100元", 1, ImagePosition.Center, "", ms);
            Response.Clear();
            Response.ContentType = "image/jpeg";
            Response.BinaryWrite(ms.ToArray());
            ms.Dispose();
        }
    }
}