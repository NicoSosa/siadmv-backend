using SiadMV.API.Application.Commands.Identity;
using FluentValidation;

namespace SiadMV.API.Validators.Identity
{
    public class UpdateUserAddressCommandValidator : AbstractValidator<UpdateUserAddressCommand>
    {
        public UpdateUserAddressCommandValidator()
        {
            RuleFor(x => x.UserAddressId).NotEmpty();
            RuleFor(x => x.Address1).NotNull().NotEmpty().MaximumLength(150);
            RuleFor(x => x.Address2).MaximumLength(150);
            RuleFor(x => x.City).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x => x.State).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x => x.Zipcode).NotNull().NotEmpty().MaximumLength(5);
            RuleFor(x => x.AddressType).IsInEnum();
        }
    }
}
