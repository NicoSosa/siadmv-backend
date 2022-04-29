using SiadMV.API.Application.Commands.Identity;
using FluentValidation;

namespace SiadMV.API.Validators.Identity
{
    public class UpdateUserIdentityCommandValidator : AbstractValidator<UpdateUserIdentityCommand>
    {
        public UpdateUserIdentityCommandValidator()
        {
            RuleFor(x => x.UserIdentityId).NotEmpty();
            RuleFor(x => x.FirstName).NotNull().NotEmpty().MaximumLength(100);
            RuleFor(x => x.Surname).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x => x.Phone).Length(11);
        }
    }
}
