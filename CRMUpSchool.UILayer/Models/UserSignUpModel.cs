using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Models
{
    public class UserSignUpModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı girin.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı girin.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı girin.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen mailinizi girin.")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir mail adresi girin.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen telefonunuzu girin.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi girin.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin.")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
