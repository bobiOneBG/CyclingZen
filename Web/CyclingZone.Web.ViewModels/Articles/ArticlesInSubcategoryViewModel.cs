namespace CyclingZone.Web.ViewModels.Articles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using CyclingZone.Data.Models;
    using CyclingZone.Services.Mapping;

    public class ArticlesInSubcategoryViewModel : IMapFrom<Article>
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string ShortTitle { get; set; }

        public int SubcategoryId { get; set; }
    }
}
