using FluentValidation;
using Recipes.Core.Requests;

namespace Recipes.Core.Validators
{
    public class RequestCreateCategoryValidator : AbstractValidator<RequestCreateCategory>
    {
        public RequestCreateCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
