using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("İsim boş geçilemez.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev boş geçilemez.");
            RuleFor(x => x.ImagerUrl).NotEmpty().WithMessage("Görsel boş geçilemez.");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Personel ismi 50 karakterden uzun olamaz.");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Personel ismi 5 karakterden kısa olamaz.");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Görev tanımı 3 karakterden kısa olamaz.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Görev tanımı 50 karakterden uzun olamaz.");
        }
    }
}
