using SiadMV.API.Application.Commands.Identity;
using FluentValidation;

namespace SiadMV.API.Validators.Identity
{
    public class AddUserProviderCommandValidator: AbstractValidator<AddUserProviderCommand>
    {
        public AddUserProviderCommandValidator()
        {
            RuleFor(x => x.AuthUId).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x => x.UserIdentityId).NotNull().NotEmpty();
            RuleFor(x => x.UserProviderValue).IsInEnum();
        }
    }
}
