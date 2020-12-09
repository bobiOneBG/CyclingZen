namespace CyclingZone.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using CyclingZone.Services.Data;
    using CyclingZone.Web.ViewModels.Administration.Dashboard;
    using CyclingZone.Web.ViewModels.Articles;
    using CyclingZone.Web.ViewModels.Categories;
    using CyclingZone.Web.ViewModels.Subcategories;
    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : AdministrationController
    {
        private readonly ISettingsService settingsService;
        private readonly IArticleService articleService;
        private readonly ICategoriesService categoriesService;
        private readonly ISubcategoriesService subcategoriesService;

        public DashboardController(
            ISettingsService settingsService,
            IArticleService articleService,
            ICategoriesService categoriesService,
            ISubcategoriesService subcategoriesService)
        {
            this.settingsService = settingsService;
            this.articleService = articleService;
            this.categoriesService = categoriesService;
            this.subcategoriesService = subcategoriesService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel { SettingsCount = this.settingsService.GetCount(), };
            return this.View(viewModel);
        }

        public IActionResult Create()
        {
            var categories = this.categoriesService.GetAll<CategoryDropdownViewModel>();
            var subcategories = this.subcategoriesService.GetAll<SubcategoriesDropdownViewModel>();
            var viewModel = new ArticleCreateInputModel
            {
                Categories = categories,
                Subcategories = subcategories,
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ArticleCreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var articleId = await this.articleService
                  .CreateArticle(input.Title, input.Subtitle, input.Author,
                      input.ImageUrl, input.Content, input.CategoryId, input.SubcategoryId);

            // TO DO...Show created article
            return this.RedirectToAction(string.Empty, new { id = articleId });
        }
    }
}
