namespace CyclingZone.Services.Data
{
    using System.Collections.Generic;

    public interface ISubcategoriesService
    {
        IEnumerable<T> GetAll<T>();

        IEnumerable<T> GetByCategoryId<T>(int? categoryId);
    }
}
