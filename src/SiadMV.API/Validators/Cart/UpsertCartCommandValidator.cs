using SiadMV.API.Application.Commands.Cart;
using FluentValidation;

namespace SiadMV.API.Validators.Cart
{
    public class UpsertCartCommandValidator : AbstractValidator<UpsertCartCommand>
    {
        public UpsertCartCommandValidator()
        {
            RuleFor(x => x.UserIdentityId).NotNull().NotEmpty();
            RuleFor(x => x.Status).IsInEnum();
            RuleFor(x => x.Status).Equal(Enums.CartStatus.Empty).When(x => x.CartProducts.Count == 0);
            RuleFor(x => x.RefreshCartDate).NotNull().NotEmpty();
            RuleFor(x => x).NotNull().NotEmpty();
            RuleForEach(x => x.CartProducts).Empty().When(x => x.Status.Equals(Enums.CartStatus.Empty));
            RuleForEach(x => x.CartProducts).SetValidator(new CartProductForCommandValidator());
        }
    }
}
