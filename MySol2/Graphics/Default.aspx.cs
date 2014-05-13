using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using MyGraphics.App_Code; 

namespace MyGraphics
{
    public partial class _Default : System.Web.UI.Page
    {

        string fileName = @"D:\Users\w.sun\Pictures\test.jpg";
        string text = "酒店名称：上海国际和平大饭店";
        protected void Page_Load(object sender, EventArgs e)
        {



            CommonMethod.DrawWords("", "酒店价格：100元", 135, ImagePosition.RightTop, "");
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
           // if (!File.Exists(fileName))
           // {
           //     throw new FileNotFoundException("The file don't exist!");
           // }

           // if (text == string.Empty)
           // {
           //     return;
           // }
           // //还需要判断文件类型是否为图像类型，这里就不赘述了  

           // System.Drawing.Image image = System.Drawing.Image.FromFile(fileName);
           // Bitmap bitmap = new Bitmap(image, image.Width, image.Height);
           // Graphics g = Graphics.FromImage(bitmap);

           // float fontSize = 12.0f;    //字体大小  
           // float textWidth = text.Length * fontSize;  //文本的长度  
           // //下面定义一个矩形区域，以后在这个矩形里画上白底黑字  
           // float rectX = 0;
           // float rectY = 0;
           // float rectWidth = text.Length * (fontSize + 8);
           // float rectHeight = fontSize + 8;
           // //声明矩形域  
           // RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);

           // Font font = new Font("宋体", fontSize);   //定义字体  
           // Brush whiteBrush = new SolidBrush(Color.White);   //白笔刷，画文字用  
           // Brush blackBrush = new SolidBrush(Color.Black);   //黑笔刷，画背景用  

           //// g.FillRectangle(blackBrush, rectX, rectY, rectWidth, rectHeight);

           // g.DrawString(text, font, whiteBrush, textArea);
           // MemoryStream ms = new MemoryStream();
           // //保存为Jpg类型  
           // bitmap.Save(ms, ImageFormat.Jpeg);

           // //输出处理后的图像，这里为了演示方便，我将图片显示在页面中了  
           // Response.Clear();
           // Response.ContentType = "image/jpeg";
           // Response.BinaryWrite(ms.ToArray());

           // g.Dispose();
           // bitmap.Dispose();
           // image.Dispose();

        }
    }
}