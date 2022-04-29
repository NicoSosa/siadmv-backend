using SiadMV.API.Application.Commands.Identity;
using FluentValidation;

namespace SiadMV.API.Validators.Identity
{
    public class RemoveUserIdentityCommandValidator : AbstractValidator<RemoveUserIdentityCommand>
    {
        public RemoveUserIdentityCommandValidator()
        {
            RuleFor(x => x.UserIdentityId).NotEmpty();
        }
    }
}
