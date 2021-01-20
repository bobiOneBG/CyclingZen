namespace CyclingZone.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CyclingZone.Data.Models.ForumModels;

    public class ForumCategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.ForumCategories.Any())
            {
                return;
            }

            var forumCategories = new Dictionary<string, string>()
            {
                { "Road beginners", "New to cycling? Want some advice? Start here..." },
                { "Road general", "General road bike chat that does not fit elsewhere" },
                { "Workshop", "Ask for advice or share your fettling tips" },
                { "Training, fitness and health", "Training and health tips " },
                { "Amateur race", "Talk about your races - time trials, road races or cyclocross" },
                { "Pro race", "Talk about competitive road cycling in all its forms" },
                { "Vintage bikes", "A place for the lovers of vintage bikes" },
                { "Cyclocross", "Go on, it is time to get muddy" },
            };

            foreach (var category in forumCategories)
            {
                await dbContext.AddAsync(new ForumCategory
                {
                    Name = category.Key,
                    Description = category.Value,
                });
            }
        }
    }
}
