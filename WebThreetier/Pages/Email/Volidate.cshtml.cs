using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;

namespace WebThreetier.Pages.Email
{
    public class ValidateModel : PageModel
    {
        private const string _id = "id";
        private const string _code = "code";
        public const string Valid = "valid";

        private UserService _userService;
        public ValidateModel()
        {
            _userService = new UserService();
        }

        [BindProperty]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public void OnGet()
        {
            //�õ�Email
            string id = Request.Query[_id];
            string code = Request.Query[_code];

            //����Email
            if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(code))
            {
                ViewData[Valid] = 
                    _userService.ValidateEmail(Convert.ToInt32(id), code);
            }
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            string ValidationUrlFormate = $"{Request.Scheme}://{Request.Host}Email/Validate?{_code}={0}&{_id}={1}";

            _userService.SendValidationEmail(EmailAddress, ValidationUrlFormate);
        }
        //��SRV�㼤��Email
    }
}