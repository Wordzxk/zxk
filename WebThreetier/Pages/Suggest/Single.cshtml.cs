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
    public class SingleModel : _LayoutModel
    {
        private SuggestService _SuggestService; 
        public SingleModel()
        {
            _SuggestService = new SuggestService(); 
        }
        public BLL.Blog Blog { get; set; }
        [BindProperty]
        public int Id { get; set; }
        public override void OnGet()
        {
            Blog= _SuggestService.Get(Id);
        }

        public void OnPost()
        {

        }
    }
}