namespace CyclingZone.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CyclingZone.Data.Models;

    public class SubcategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Subcategories.Any())
            {
                return;
            }

            var subcategories = new string[]
            {
                "Racing",
                "General News",
                "Product News",
                "Bike Reviews",
                "Bike Components",
                "Bike Accessories",
                "Clothing",
                "Bike Fit",
                "Nutrition",
                "Training",
            };

            var categoryId = 1;
            for (int i = 0; i < 3; i++)
            {
                await AddToDb(dbContext, subcategories, categoryId, i);
            }

            categoryId++;

            for (int i = 3; i < 7; i++)
            {
                await AddToDb(dbContext, subcategories, categoryId, i);
            }

            categoryId++;

            for (int i = 7; i < subcategories.Length; i++)
            {
                await AddToDb(dbContext, subcategories, categoryId, i);
            }

            await dbContext.SaveChangesAsync();
        }

        private static async Task AddToDb(ApplicationDbContext dbContext, string[] subcategories, int catId, int i)
        {
            var subcategory = new Subcategory
            {
                CategoryId = catId,
                Name = subcategories[i],
            };

            await dbContext.Subcategories.AddAsync(subcategory);
        }
    }
}
