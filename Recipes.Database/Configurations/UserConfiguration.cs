using Microsoft.EntityFrameworkCore;
using Recipes.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Database.Configurations
{
    public static class UserConfiguration
    {
        public static void ConfigureUser(this ModelBuilder builder)
        {
            builder.Entity<User>()
            .HasMany(x => x.Recipes)
            .WithOne(y => y.User)
            .HasForeignKey(x => x.CreatedBy);
        }
    }
}
