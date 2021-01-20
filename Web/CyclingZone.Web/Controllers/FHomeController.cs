namespace CyclingZone.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CyclingZone.Services.Data.Forum;
    using CyclingZone.Web.ViewModels.ForumHome;
    using Microsoft.AspNetCore.Mvc;

    public class FHomeController : BaseController
    {
        private readonly IForumCategoriesService forumCategories;

        public ForumHomeController(IForumCategoriesService forumCategories)
        {
            this.forumCategories = forumCategories;
        }

        public IActionResult Index()
        {
            var categories = this.forumCategories.GetAll<IndexForumCategoryViewModel>();

            return this.View(categories);
        }
    }
}
