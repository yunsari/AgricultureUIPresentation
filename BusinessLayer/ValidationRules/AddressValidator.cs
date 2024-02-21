using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Desc1).NotEmpty().WithMessage("Açıklama boş geçilemez.");
            RuleFor(x => x.Desc2).NotEmpty().WithMessage("Açıklama boş geçilemez.");
            RuleFor(x => x.Desc3).NotEmpty().WithMessage("Açıklama boş geçilemez.");
            RuleFor(x => x.Desc4).NotEmpty().WithMessage("Açıklama boş geçilemez.");
            RuleFor(x => x.MapInfo).NotEmpty().WithMessage("Harita bilgisi boş geçilemez.");
        }
    }
}
