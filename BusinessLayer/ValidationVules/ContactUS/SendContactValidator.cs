using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationVules.ContactUS
{
   public class SendContactValidator:AbstractValidator<SendMessageDTO>
    {
        public SendContactValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş geçilemez..");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Alanı Boş geçilemez..");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş geçilemez..");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj Alanı Boş geçilemez..");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu Alanına en az 5 karakter veri girişi yapmalısınız..");
            RuleFor(x => x.Subject).MinimumLength(250).WithMessage("Konu Alanına en fazla 250 karakter veri girişi yapmalısınız..");
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("Mail Alanına en az 5 karakter veri girişi yapmalısınız..");
            RuleFor(x => x.Mail).MinimumLength(64).WithMessage("Mail Alanına en fazla 64 karakter veri girişi yapmalısınız..");
        }
    }
}
