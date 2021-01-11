namespace CyclingZone.Web.ViewModels.Subcategories
{
    using System.Collections.Generic;

    using CyclingZone.Data.Models;
    using CyclingZone.Web.ViewModels.Articles;

    public class IndexSubcategoryViewModel
    {
        public IEnumerable<ArticleInSubcategoryViewModel> Articles { get; set; }
    }
}
