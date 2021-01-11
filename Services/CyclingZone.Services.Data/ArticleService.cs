namespace CyclingZone.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CyclingZone.Data.Common.Repositories;
    using CyclingZone.Data.Models;
    using CyclingZone.Services.Mapping;

    public class ArticleService : IArticleService
    {
        private const int ArticlesCount = 3;

        private readonly IDeletableEntityRepository<Article> articleRepository;
        private readonly IDeletableEntityRepository<Category> categoryRepository;
        private readonly IDeletableEntityRepository<Subcategory> subcategoryRepository;

        public ArticleService(
            IDeletableEntityRepository<Article> articleRepository,
            IDeletableEntityRepository<Category> categoryRepository,
            IDeletableEntityRepository<Subcategory> subcategoryRepository)
        {
            this.articleRepository = articleRepository;
            this.categoryRepository = categoryRepository;
            this.subcategoryRepository = subcategoryRepository;
        }

        public int GetSubcategoryId(int id)
        {
            var subcategoryId = this.articleRepository.All()
                .Where(x => x.Id == id).FirstOrDefault().SubcategoryId;

            return subcategoryId;
        }

        public T GetById<T>(int id)
        {
            var article = this.articleRepository.All().Where(x => x.Id == id).To<T>().FirstOrDefault();

            return article;
        }

        public IEnumerable<T> GetAll<T>(string subcategoryName)
        {
            var articles = this.articleRepository.All()
                .Where(x => x.Subcategory == subcategoryName)
                .OrderByDescending(x => x.CreatedOn);

            return articles.To<T>().ToList();
        }

        public IEnumerable<T> GetAll<T>(int? count = default(int))
        {
            var articles = this.articleRepository.All()
                .OrderByDescending(x => x.CreatedOn);

            if (count.HasValue)
            {
                articles = (IOrderedQueryable<Article>)articles.Take(count.Value);
            }

            return articles.To<T>().ToList();
        }

        public IEnumerable<T> GetBySubcategoryId<T>(int id, int subcategoryId, int? count)
        {
            var articles = this.articleRepository.All().Where(x => x.SubcategoryId == subcategoryId && x.Id != id);
            if (count.HasValue)
            {
                articles = articles.Take(ArticlesCount);
            }

            return articles.To<T>().ToList();
        }

        public async Task<int> CreateArticle(string title, string subtitle,
            string author, string imageUrl, string content, int categoryId, int subcategoryId)
        {
            // Remove Prefix CategoryId(from ArticleCreateInputModel)
            var removePrefixSubcategoryId = this.RemoveFirstDigit(subcategoryId);

            var article = new Article
            {
                Title = title,
                Subtitle = subtitle,
                Author = author,
                ImageUrl = imageUrl,
                Content = content,
                CategoryId = categoryId,
                SubcategoryId = removePrefixSubcategoryId,
            };

            article.Category = this.categoryRepository.All()
                .Where(x => x.Id == categoryId)
                .FirstOrDefault().Name;
            article.Subcategory = this.subcategoryRepository.All()
                .Where(x => x.Id == removePrefixSubcategoryId)
                .FirstOrDefault()
                .Name;

            await this.articleRepository.AddAsync(article);
            await this.articleRepository.SaveChangesAsync();

            return article.Id;
        }

        private int RemoveFirstDigit(int i)
        {
            var str = i.ToString()[1..];

            return int.Parse(str);
        }
    }
}
