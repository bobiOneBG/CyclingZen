namespace CyclingZone.Web.Controllers
{
    using CyclingZone.Services.Data;
    using CyclingZone.Web.ViewModels.Articles;
    using CyclingZone.Web.ViewModels.Subcategories;
    using Microsoft.AspNetCore.Mvc;

    public class SubcategoriesController : Controller
    {
        private readonly IArticleService articleService;

        public SubcategoriesController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        // GET: SubcategoriesController
        public ActionResult Index(int articleId, int subcategoryId)
        {
            var article = this.articleService.GettById<ArticleViewModel>(articleId);

            var articles = this.articleService
                   .GetBySubcategoryId<ArticlesInSubcategoryViewModel>(subcategoryId);

            var viewModel = new IndexSubcategoryViewModel
            {
                LatestArticle = article,
                Articles = articles,
            };

            return this.View(viewModel);
        }
    }
}
