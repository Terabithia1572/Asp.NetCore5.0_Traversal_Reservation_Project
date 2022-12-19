using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Şifre Minimum {length} karakter olmalıdır.."
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code="PasswordRequiresUpper",
                Description="Şifre en az 1 karakter içermelidir..."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError() {
            
            Code= "PasswordRequiresNonAlphanumeric",
            Description="Şifre en az 1 tane özel karakter (/ * - $ ½ vb.) içermelidir.."
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Şifre en az 1 tane rakam içermelidir.."
            };
        }
    }
    
}
