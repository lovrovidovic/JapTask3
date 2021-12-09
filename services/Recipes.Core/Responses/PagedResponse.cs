using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core.Responses
{
    public class PagedResponse<T>
    {
        public int NextPage { get; set; }

        public int Count { get; set; }

        public T Data { get; set; }
    }
}
