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
        private SuggsetService _suggsetService;
        public NewModel()
        {
            _suggsetService = new SuggsetService();
        }


        [Required]
        [StringLength(10)]
        public string Title { get; set; }
        [Required]
        [MinLength(10)]
        [StringLength(30)]
        public string Body { get; set; }

        public override void OnGet()
        {
            base.OnGet();
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
           

            _suggsetService.Publish(Title, Body, CurrentUserId.Value);
        }
    }
}