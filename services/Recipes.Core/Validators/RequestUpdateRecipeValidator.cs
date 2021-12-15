using FluentValidation;
using Recipes.Core.Requests;

namespace Recipes.Core.Validators
{
    public class RequestUpdateRecipeValidator : AbstractValidator<RequestUpdateRecipe>
    {
        public RequestUpdateRecipeValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.CategoryId).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.RecipeIngredient).NotEmpty();
            RuleFor(x => x.RecommendedPrice).NotEmpty();
        }
    }
}
