using FluentValidation;
using Recipes.Core.Requests;

namespace Recipes.Core.Validators
{
    public class RequestCreateRecipeValidator : AbstractValidator<RequestCreateRecipe>
    {
        public RequestCreateRecipeValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.CategoryId).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.RecipeIngredient).NotEmpty();
            RuleFor(x => x.RecommendedPrice).NotEmpty();
        }
    }
}
