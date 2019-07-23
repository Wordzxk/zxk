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
        public string Title { get; set; }
        [StringLength(60)]
        public string Body { get; set; }

        public override void OnGet()
        {

        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            UserModel currentUser = JsonConvert.DeserializeObject<UserModel>(
                 HttpContext.Session.GetString("UserName"));
            _suggsetService.Publish(Title, Body, currentUser.Id);
        }
    }
}