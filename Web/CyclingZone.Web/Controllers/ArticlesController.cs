namespace CyclingZone.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CyclingZone.Data.Models;
    using CyclingZone.Services.Data;
    using CyclingZone.Web.ViewModels.Articles;
    using CyclingZone.Web.ViewModels.Home;
    using CyclingZone.Web.ViewModels.Subcategories;
    using Microsoft.AspNetCore.Mvc;

    public class ArticlesController : BaseController
    {
        private const int ArticlesCount = 3;

        private readonly IArticleService articleService;

        public ArticlesController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public IActionResult ById(int id)
        {
            var articleViewModel = this.articleService.GetById<ArticleViewModel>(id);

            var subcategoryId = this.articleService.GetSubcategoryId(id);
            articleViewModel.Articles = this.articleService
                .GetBySubcategoryId<IndexArticleViewModel>(id, subcategoryId, ArticlesCount);

            return this.View(articleViewModel);
        }
    }
}
