using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_UI.Controllers
{
    public class CaptchaController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Get()
        {
            return File(MakeCaptaha(), "jpg");
        }

        public byte[] MakeCaptaha()
        {
            Bitmap bitmap = new Bitmap(60, 30);
            Graphics graphics = Graphics.FromImage(bitmap);
            Font font = new Font("Arial", 15, (FontStyle.Bold | FontStyle.Italic));
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, bitmap.Width, bitmap.Height)
                , Color.DarkCyan, Color.AliceBlue, 1.1f, true);

            graphics.DrawString("", font, brush, 3, 2);
            //保存图片
            MemoryStream stream = new MemoryStream();
            bitmap.Save(stream, ImageFormat.Jpeg);
            //输出图片
            return stream.ToArray();
        }
    }
}