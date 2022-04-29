using SiadMV.API.Application.Commands.Identity;
using FluentValidation;

namespace SiadMV.API.Validators.Identity
{
    public class AddUserIdentityCommandValidator : AbstractValidator<AddUserIdentityCommand>
    {
        public AddUserIdentityCommandValidator()
        {
            RuleFor(x => x.Email).NotNull().NotEmpty().EmailAddress().MaximumLength(50);
            RuleFor(x => x.FirstName).MaximumLength(100);
            RuleFor(x => x.Surname).MaximumLength(50);
            RuleFor(x => x.Phone).Length(11);
            RuleFor(x => x.Provider).NotEmpty().NotNull();
        }
    }
}
