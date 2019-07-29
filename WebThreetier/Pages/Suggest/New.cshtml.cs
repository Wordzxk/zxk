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
        private SuggestService _suggestService;

        public NewModel()
        {
            _suggestService = new SuggestService();
        }


        [Required]
        public string Title { get; set; }
        [Required]
        [MinLength(10)]
        public string Body { get; set; }

        //public DTOSuggest Suggest { get; set; }

        public override void OnGet()
        {
            base.OnGet();
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return ;
            }
            //反序列化
            //UserModel currentUser = JsonConvert.DeserializeObject<UserModel>(
            //    HttpContext.Session.GetString("UserName"));
            _suggestService.Publish(Title, Body, CurrentUserId.Value);
        }
    }
}