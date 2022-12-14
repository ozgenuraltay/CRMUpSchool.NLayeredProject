using CRMUpSchool.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.BusinessLayer.ValidationRules
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Personel adı boş olamaz.");
            RuleFor(x => x.EmployeeName).MinimumLength(2).WithMessage("Lütfen en az iki karakter giriniz.");
            RuleFor(x => x.EmployeeName).MaximumLength(20).WithMessage("Lütfen en çok 20 karakter giriniz.");
            RuleFor(x => x.EmployeeSurname).NotEmpty().WithMessage("Personel soyadı boş olamaz.");
        }
    }
}
