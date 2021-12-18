using Entities.Concrete.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    class StudentValidator:AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(y => y.StudentName).NotEmpty().WithMessage("Lütfen öğrenci ismi alanını doludurunuz");
            RuleFor(y => y.StudentName).MinimumLength(3).WithMessage("Lütfen minumum 3 karakter giriniz");
            RuleFor(x => x.StudentName).MaximumLength(50).WithMessage("Lütfen maximum 50 karakter giriniz");
            RuleFor(x => x.StudentNumber).MinimumLength(1).WithMessage("Lütfen minumum 1 karakter giriniz");
            RuleFor(x => x.StudentNumber).MaximumLength(15).WithMessage("Lütfen maximum 15 karakter giriniz");
            RuleFor(x => x.StudentNumber).NotEmpty().WithMessage("Lütfen Öğrenci numarası alanını boş geçmeyiniz");
            RuleFor(x => x.StudentGender).NotEmpty().WithMessage("Lütfen bu alanı işaretleyiniz");
            RuleFor(x => x.StudentStatus).NotEmpty().WithMessage("Lütfen bu alanı işaretleyiniz");
            RuleFor(x => x.StudentSurname).NotEmpty().WithMessage("Lütfen öğrenci soyismi alanını boş geçmeyiniz");
            RuleFor(x => x.StudentSurname).NotEmpty().WithMessage("Lütfen öğrenci soyismi alanını boş geçmeyiniz");
            RuleFor(x => x.StudentIdentityNumber).NotEmpty().WithMessage("Lütfen öğrenci tc no alanını boş geçmeyiniz");
            RuleFor(x => x.StudentIdentityNumber).MinimumLength(11).WithMessage("tc kimlik alanı minumum ve maximum 11 karakterden oluşmak zorundadır");
            RuleFor(x => x.StudentIdentityNumber).MaximumLength(11).WithMessage("tc kimlik alanı minumum ve maximum 11 karakterden oluşmak zorundadır");

        }
    }
}
