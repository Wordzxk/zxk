using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SRV;
using SRV.Model;
using WebThreetier.Pages.Shared;

namespace WebThreetier.Pages
{
    [BindProperties]
    public class NewModel : _LayoutModel
    {
        private ISuggestService _suggsetService;

        public NewModel(ISuggestService suggestService)
        {
            _suggsetService = suggestService;
        }


        [Required]
        [StringLength(10)]
        public string Title { get; set; }
        [Required]
        [MinLength(10)]
        public string Body { get; set; }

        public DTOSuggest Suggest { get; set; }

        public override void OnGet()
        {
            base.OnGet();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            int id = _suggsetService.Publish(Title, Body).Id;
            return Redirect("/Suggest/Single?id=" + id);
            //_suggsetService.Publish(Title, Body, CurrentUserId.Value);
        }
    }
}