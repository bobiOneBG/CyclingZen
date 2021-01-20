namespace CyclingZone.Services.Data.Forum
{
    using System.Collections.Generic;

    public interface IForumCategoriesService
    {
        IEnumerable<T> GetAll<T>();
    }
}
