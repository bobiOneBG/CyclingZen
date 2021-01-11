namespace CyclingZone.Web.ViewModels.Articles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using CyclingZone.Data.Models;
    using CyclingZone.Services.Mapping;
    using Ganss.XSS;

    public class ArticleInSubcategoryViewModel : IMapFrom<Article>
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string ShortTitle { get; set; }

        public string Content { get; set; }

        public string SanitizedContent => new HtmlSanitizer().Sanitize(this.Content);

        public int SubcategoryId { get; set; }
    }
}
