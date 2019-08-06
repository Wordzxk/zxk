using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using WebThreetier.Pages.Shared;

namespace WebThreetier.Pages.Suggest
{
    public class IndexModel : _LayoutModel
    {
        //private SuggestService _SuggestService;
        //public IndexModel()
        //{
        //    _SuggestService = new SuggestService();
        //}
        public BLL.Blog Blogs { get; set; }
        //[BindProperty]
        //public int Id { get; set; }

        public override void OnGet()
        {
           
        }

        public void OnPost()
        {

        }
    }
}