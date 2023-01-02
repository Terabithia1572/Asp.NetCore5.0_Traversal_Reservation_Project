using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationVules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.GuideName).NotEmpty().WithMessage("Lütfen rehber adını giriniz");
            RuleFor(x => x.GuideDescription).NotEmpty().WithMessage("Lütfen rehber açıklamasını giriniz");
            RuleFor(x => x.GuideImage).NotEmpty().WithMessage("Lütfen rehber görselini giriniz");
            RuleFor(x => x.GuideName).MaximumLength(30).WithMessage("lütfen 30 karakterden daha kısa bir isim giriniz");
            RuleFor(x => x.GuideName).MinimumLength(8).WithMessage("lütfen 8 karakterden daha uzun bir isim giriniz");

        }
    }
}
