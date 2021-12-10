using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core.Requests
{
    public class RequestGetPagedIngredients : BaseSearch
    {
        public int PageSize { get; set; }
    }
}
