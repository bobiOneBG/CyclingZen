namespace CyclingZone.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IArticleService
    {
        Task<int> CreateArticle(string title, string subtitle,
            string author, string imageUrl, string content, int categoryId, int subcategoryId);

        IEnumerable<T> GetAll<T>(int? count = null);

        IEnumerable<T> GetBySubcategoryId<T>(int id, int categoryId, int? count = null);

        int GetSubcategoryId(int id);

        T GetById<T>(int id);

        IEnumerable<T> GetAll<T>(string name);
    }
}
