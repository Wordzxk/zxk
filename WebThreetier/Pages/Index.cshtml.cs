using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebThreetier.Pages.Shared;

namespace WebThreetier.Pages
{
    public class IndexModel : _LayoutModel                /*PageModel*/
    {
        public override void OnGet()
        {
            base.OnGet();
        }
        public void OnPost()
        {

        }
    }
}
