using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using WebThreetier.Pages.Shared;

namespace WebThreetier.Pages
{
    [BindProperties]
    public class IndexModel : _LayoutModel               
    {
        private ISuggestService _SuggestService;
        public IndexModel(ISuggestService suggestService)
        {
            _SuggestService = suggestService;
        }

        public int PageIndex { get; set; }
        public IList<BLL.Blog> Blogs { get; set; }


        public override void OnGet()
        {
            Blogs = _SuggestService.Get(PageIndex, 1);
        }
        public void OnPost()
        {

        }
    }
}
