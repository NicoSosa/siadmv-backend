using SiadMV.API.Application.Commands.Identity;
using FluentValidation;

namespace SiadMV.API.Validators.Identity
{
    public class RemoveUserAddressCommandValidator : AbstractValidator<RemoveUserAddressCommand>
    {
        public RemoveUserAddressCommandValidator()
        {
            RuleFor(x => x.UserAddressId).NotEmpty();
        }
    }
}
