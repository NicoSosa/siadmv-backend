using SiadMV.API.Application.Commands.Identity;
using FluentValidation;


namespace SiadMV.API.Validators.Identity
{
    public class RemoveUserProviderCommandValidator: AbstractValidator<RemoveUserProviderCommand>
    {
        public RemoveUserProviderCommandValidator()
        {
            RuleFor(x => x.AuthUId).NotEmpty();
        }
    }
}
