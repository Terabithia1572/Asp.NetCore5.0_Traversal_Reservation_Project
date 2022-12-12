using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationVules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.AboutDescription).NotEmpty().WithMessage("Açıklama Kısmını Boş Geçemezsiniz...");
            RuleFor(x => x.AboutImage1).NotEmpty().WithMessage("Lütfen Resim Kısmını Boş Geçemezsiniz..");
            RuleFor(x => x.AboutDescription).MinimumLength(10).WithMessage("Lütfen En Az 10 Karakter Giriniz..");
        }
    }
}
