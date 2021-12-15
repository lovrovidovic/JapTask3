using Recipes.Common.Enums;
using Recipes.Core.Dtos;

namespace Recipes.Core.Requests
{
    public class RequestGetPagedIngredients : BaseSearch
    {
        public int PageSize { get; set; }

        public IngredientFiltersDto Filters { get; set; }

        public string SortBy { get; set; }

        public SortOrder SortOrder { get; set; }
    }
}
