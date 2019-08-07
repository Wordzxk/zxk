using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMVC_UI.Models.Register
{
    public class IndexModel
    {
        [Required(ErrorMessage = "*用户民不能为空┗|｀O′|┛ 嗷~~")]
        public string UserName { get; set; } = "用户名";
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}