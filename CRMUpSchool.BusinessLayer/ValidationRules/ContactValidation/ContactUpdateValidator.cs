using CRMUpSchool.DTOLayer.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.BusinessLayer.ValidationRules.ContactValidation
{
    public class ContactUpdateValidator:AbstractValidator<ContactUpdateDTO>
    {
        public ContactUpdateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad boş geçilemez.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail boş geçilemez.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu boş geçilemez.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Mesaj boş geçilemez.");
            RuleFor(x => x.Name).MinimumLength(10).WithMessage("Lütfen minimum 10 karakter veri girişi yapınız.");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Lütfen minimum 5 karakter veri girişi yapınız.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen maksimum 50 karakter veri girişi yapınız.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen maksimum 100 karakter veri girişi yapınız.");
        }
    }
}
