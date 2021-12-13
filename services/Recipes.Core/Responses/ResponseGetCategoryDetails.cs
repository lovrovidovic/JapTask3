using Recipes.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core.Responses
{
    public class ResponseGetCategoryDetails
    {
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public int CreatedBy { get; set; }

        public List<GetRecipeOfCategoryDto> Recipes { get; set; }
    }
}
