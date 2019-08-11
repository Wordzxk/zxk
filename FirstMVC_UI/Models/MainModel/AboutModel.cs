using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_UI.Models.MainModel
{
    public class AboutModel
    {
        public string Greet { get; } = "用户登陆";
        [MinLength(6)]
        [Required(ErrorMessage = "* 用户名不能为空(￣▽￣)")]
        public string UserName { get; set; }
        [MinLength(4)]
        [Required(ErrorMessage = "* 密码不能为空o(*￣▽￣*)o")]
        public int Password { get; set; }
        public string Captcha{ get; set; }
        public bool RememberMe { get; set; }

    }

}