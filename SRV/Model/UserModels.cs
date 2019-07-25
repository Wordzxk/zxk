using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV.Model
{
    [BindProperties]
    public class UserModel
    {
        //用于-LayoutModel
        public int Id { get; set; }
        public string Name { get; set; }
        public string MD5Password { get; set; }

    }
}
