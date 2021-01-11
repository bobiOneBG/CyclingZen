namespace CyclingZone.Web.Controllers
{
    using System.Linq;

    using CyclingZone.Services.Data;
    using CyclingZone.Web.ViewModels.Articles;
    using CyclingZone.Web.ViewModels.Subcategories;
    using Microsoft.AspNetCore.Mvc;

    public class SubcategoriesController : Controller
    {
        private readonly ISubcategoriesService subcategoriesService;
        private readonly IArticleService articleService;

        public SubcategoriesController(
            ISubcategoriesService subcategoriesService,
            IArticleService articleService)
        {
            this.subcategoriesService = subcategoriesService;
            this.articleService = articleService;
        }

        // GET: Subcategories/ Index
        public IActionResult Index(int articleId, int subcategoryId)
        {
            var articles = this.articleService
                   .GetBySubcategoryId<ArticleInSubcategoryViewModel>(articleId, subcategoryId);

            var viewModel = new IndexSubcategoryViewModel
            {
                Articles = articles,
            };

            return this.View(viewModel);
        }

        public IActionResult ByName(string name)
        {
            var articles = this.articleService.GetAll<ArticleInSubcategoryViewModel>(name);

            var viewModel = new IndexSubcategoryViewModel
            {
                Articles = articles,
            };

            return this.View(viewModel);
        }
    }
}
