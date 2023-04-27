using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationVules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez..");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("SoyadAd Alanı Boş Geçilemez..");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez..");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez..");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez..");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Geçilemez..");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Veri Girişi Yapınız..");
            RuleFor(x => x.Username).MaximumLength(25).WithMessage("Lütfen En Fazla 25 Karakter Veri Girişi Yapınız..");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler Birbiriyle Uyuşmuyor..");
        }
    }
}
