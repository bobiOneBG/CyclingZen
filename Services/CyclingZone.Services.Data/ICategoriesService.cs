using System.Collections.Generic;

namespace CyclingZone.Services.Data
{
    public interface ICategoriesService
    {
        IEnumerable<T> GetAll<T>();
    }
}