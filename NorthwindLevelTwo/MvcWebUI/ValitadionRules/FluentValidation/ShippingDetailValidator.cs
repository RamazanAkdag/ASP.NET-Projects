using FluentValidation;
using MvcWebUI.Models;

namespace MvcWebUI.ValitadionRules.FluentValidation
{
    public class ShippingDetailValidator:AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("Adı Gereklidir");
            RuleFor(s => s.FirstName).MinimumLength(2);
            RuleFor(s=>s.LastName).NotEmpty();
            RuleFor(s=>s.Address).NotEmpty();
            RuleFor(s=> s.City).NotEmpty().When(s=>s.Age<18);
            //RuleFor(s => s.FirstName).Must(StartsWithA);
        }

        private bool StartsWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
