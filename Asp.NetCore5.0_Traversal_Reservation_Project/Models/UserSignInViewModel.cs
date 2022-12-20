using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz..")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Giriniz..")]

        public string Password { get; set; }
    }
}
