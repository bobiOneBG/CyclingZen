namespace CyclingZone.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CyclingZone.Data.Common.Models;
    using CyclingZone.Data.Common.Repositories;
    using CyclingZone.Data.Models;
    using CyclingZone.Services.Mapping;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categotiesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categotiesRepository)
        {
            this.categotiesRepository = categotiesRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var categories = this.categotiesRepository.All().To<T>().ToList();

            return categories;
        }
    }
}
