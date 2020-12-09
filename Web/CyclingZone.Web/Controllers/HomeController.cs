namespace CyclingZone.Web.Controllers
{
    using System.Diagnostics;

    using CyclingZone.Services.Data;
    using CyclingZone.Web.ViewModels;
    using CyclingZone.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private const int ArticlesCount = 4;

        private readonly IArticleService articleService;

        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public IActionResult Index()
        {
            var articles = this.articleService.GetAll<IndexArticleViewModel>(ArticlesCount);

            return this.View(new IndexViewModel { Articles = articles });
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
