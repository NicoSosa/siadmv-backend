using SiadMV.API.Application.Commands.UserCase;
using FluentValidation;
using System;
using System.Text.RegularExpressions;

namespace SiadMV.API.Validators.UserCase
{
    public class SearchKeysFactInUserCaseCommandValidator : AbstractValidator<SearchKeysFactInUserCaseCommand>
    {
        public SearchKeysFactInUserCaseCommandValidator()
        {
            RuleFor(uc => uc.Description).NotEmpty().NotNull();
            RuleFor(uc => uc.Description)
                .Custom(
                    (description, context) =>
                    {
                        //string sqlRegEx = "1'OR'=1'";
                        //string sqlRegEx = @"SELECT\s.*FROM\s.*WHERE\s.*";
                        string sqlRegEx = "(ALTER|CREATE|DELETE|DROP|EXEC(UTE){0,1}|INSERT( +INTO){0,1}|MERGE|SELECT|UPDATE|UNION( +ALL){0,1})";
                        var upperDescript = description.ToUpper();

                        Regex regex = new Regex(sqlRegEx);
                        Match match = regex.Match(upperDescript);

                        if (match.Success)
                        {
                            context.AddFailure("El texto parece una inyección SQL");
                        }
                    }
                );
        }
    }
}
