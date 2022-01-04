using FluentValidation;
using Recipes.Core.Requests;

namespace Recipes.Core.Validators
{
    public class RequestUpdateIngredientValidator : AbstractValidator<RequestUpdateIngredient>
    {
        public RequestUpdateIngredientValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.NormativePrice).NotEmpty();
            RuleFor(x => x.NormativeQuantity).NotEmpty();
            RuleFor(x => x.NormativeUnit).NotNull();
        }
    }
}
