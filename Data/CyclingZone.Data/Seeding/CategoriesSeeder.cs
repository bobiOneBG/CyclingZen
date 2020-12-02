namespace CyclingZone.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CyclingZone.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new HashSet<string>
            {
                "News",
                "Reviews",
                "Fitness",
            };

            foreach (var categoryName in categories)
            {
                await dbContext.AddAsync(new Category
                {
                    Name = categoryName,
                });
            }

            return;
        }
    }
}
