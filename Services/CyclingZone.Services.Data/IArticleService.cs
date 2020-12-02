namespace CyclingZone.Services.Data
{
    using System.Threading.Tasks;

    public interface IArticleService
    {
        Task<int> CreateArticle(string title, string subtitle,
            string author, string imageUrl, string content, int categoryId);
    }
}
