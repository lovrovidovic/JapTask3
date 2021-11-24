using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core.Requests
{
    public class RequestSearchRecipe : BaseSearch
    {
        public string Search { get; set; }

        public int CategoryId { get; set; }
    }
}
