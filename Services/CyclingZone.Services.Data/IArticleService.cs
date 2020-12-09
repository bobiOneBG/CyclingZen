namespace CyclingZone.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IArticleService
    {
        Task<int> CreateArticle(string title, string subtitle,
            string author, string imageUrl, string content, int categoryId, int subcategoryId);

        IEnumerable<T> GetAll<T>(int? count = null);

        IEnumerable<T> GetBySubcategoryId<T>(int categoryId, int? count = null);

        int GetSubcategoryId(int id);

        T GettById<T>(int id);
    }
}
