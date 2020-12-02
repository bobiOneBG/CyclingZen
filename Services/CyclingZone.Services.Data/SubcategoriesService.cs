namespace CyclingZone.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using CyclingZone.Data.Common.Repositories;
    using CyclingZone.Data.Models;
    using CyclingZone.Services.Mapping;

    public class SubcategoriesService : ISubcategoriesService
    {
        private readonly IDeletableEntityRepository<Subcategory> subcategoriesRepository;

        public SubcategoriesService(IDeletableEntityRepository<Subcategory> subcategoriesRepository)
        {
            this.subcategoriesRepository = subcategoriesRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var subcategories = this.subcategoriesRepository.All()
                .To<T>()
                .ToList();

            return subcategories;
        }

        public IEnumerable<T> GetByCategoryId<T>(int? categoryId)
        {
            var subcategories = this.subcategoriesRepository.All();

            if (categoryId.HasValue)
            {
                subcategories = subcategories
                    .Where(x => x.CategoryId == categoryId);
            }

            return subcategories.To<T>().ToList();
        }
    }
}
