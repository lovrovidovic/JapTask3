using FluentValidation;
using Recipes.Core.Requests;

namespace Recipes.Core.Validators
{
    public class RequestUpdateCategoryValidator : AbstractValidator<RequestUpdateCategory>
    {
        public RequestUpdateCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
