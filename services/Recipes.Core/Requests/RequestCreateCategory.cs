using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core.Requests
{
    public class RequestCreateCategory
    {
        public string Name { get; set; }

        public int UserId { get; set; }
    }
}
