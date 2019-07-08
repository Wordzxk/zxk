using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationfirst.Pages
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        public RegisterModel Register { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "问号";
        }
        public void Onpost()
        {

        }
    }
}