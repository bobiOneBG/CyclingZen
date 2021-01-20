namespace CyclingZone.Services.Data.Forum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CyclingZone.Data.Common.Repositories;
    using CyclingZone.Data.Models.ForumModels;
    using CyclingZone.Services.Mapping;

    public class ForumCategoriesService : IForumCategoriesService
    {
        private readonly IDeletableEntityRepository<ForumCategory> forumCategories;

        public ForumCategoriesService(IDeletableEntityRepository<ForumCategory> forumCategories)
        {
            this.forumCategories = forumCategories;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var categories = this.forumCategories.All().To<T>().ToList();

            return categories;
        }
    }
}
