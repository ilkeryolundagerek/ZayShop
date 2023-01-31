using System.ComponentModel.DataAnnotations;

namespace ZayShop.Models.Account
{
    public class LoginViewModel
    {
        [Required, Display(Name = "E-Mail Address", Prompt = "E-Mail Address"), EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password), Display(Name = "Password", Prompt = "Password")]
        public string Password { get; set; }
    }
}