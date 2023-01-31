using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZayShop.Models.Account
{
    public class RegisterViewModel
    {
        [Required, Display(Name = "Firstname", Prompt = "Firstname")]
        public string Firstname { get; set; }

        [Display(Name = "Middlename", Prompt = "Middlename")]
        public string Middlename { get; set; }

        [Required, Display(Name = "Lastname", Prompt = "Lastname")]
        public string Lastname { get; set; }

        [Required, Display(Name = "E-Mail Address", Prompt = "E-Mail Address"), EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password), Display(Name = "Password", Prompt = "Password")]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), Display(Name = "Confirm Password", Prompt = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}