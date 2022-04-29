using SiadMV.API.Application.Commands.Cart;
using FluentValidation;

namespace SiadMV.API.Validators.Cart
{
    public class CartProductForCommandValidator : AbstractValidator<CartProductForCommand>
    {
        public CartProductForCommandValidator()
        {
            RuleFor(x => x.ProductId).NotNull().NotEmpty();
            RuleFor(x => x.Quantity).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
