using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationVules.AnnouncementValidationRules
{
    public class AnnouncementUpdateValidator:AbstractValidator<AnnouncementUpdateDTO>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlığı Boş Bırakmayınız..");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Duyuru İçeriğini Boş Bırakmayınız..");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Yazın...");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Yazın...");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen En Fazla 500 Karakter Yazın...");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen En Fazla 50 Karakter Yazın...");
        }
    }
}
