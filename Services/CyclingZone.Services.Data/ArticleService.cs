namespace CyclingZone.Services.Data
{
    using System.Threading.Tasks;

    using CyclingZone.Data.Common.Repositories;
    using CyclingZone.Data.Models;

    public class ArticleService : IArticleService
    {
        private readonly IDeletableEntityRepository<Article> articleRepository;

        public ArticleService(IDeletableEntityRepository<Article> articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public async Task<int> CreateArticle(string title, string subtitle,
            string author, string imageUrl, string content, int subcategoryId)
        {
            var article = new Article
            {
                Title = title,
                Subtitle = subtitle,
                Author = author,
                ImageUrl = imageUrl,
                Content = content,
                SubcategoryId = subcategoryId,
            };

            await this.articleRepository.AddAsync(article);
            await this.articleRepository.SaveChangesAsync();

            return article.Id;
        }
    }
}
