using alefbafilms.application.Services.Users.Commands.PostUsers;
using alefbafilms.domian.Entities.Users;
using FluentValidation;

namespace Endpoint.Site.Areas.Admin.Models.Validations
{
    public class UserValidator: AbstractValidator<RequestPostUserDto>
    {
        public UserValidator()
        {
            RuleLevelCascadeMode = CascadeMode.Continue;

            RuleFor(x => x.Fullname)
                .NotEmpty();

        }
    }
}
