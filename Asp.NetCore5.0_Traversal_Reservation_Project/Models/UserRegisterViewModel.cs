using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Adınızı Giriniz..")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz..")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz..")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Adresini Giriniz..")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz Giriniz..")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz..")]
        [Compare("Password",ErrorMessage ="Şifreler Aynı Değil")] // Compare Karşılaştırma yapıyor
        public string ConfirmPassword { get; set; }
        

    }
}
