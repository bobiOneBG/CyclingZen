namespace CyclingZone.Web.ViewModels.Subcategories
{
    using System.Collections.Generic;

    using CyclingZone.Data.Models;
    using CyclingZone.Web.ViewModels.Articles;

    public class IndexSubcategoryViewModel
    {
        public ArticleViewModel LatestArticle { get; set; }

        public IEnumerable<ArticlesInSubcategoryViewModel> Articles { get; set; }
    }
}
