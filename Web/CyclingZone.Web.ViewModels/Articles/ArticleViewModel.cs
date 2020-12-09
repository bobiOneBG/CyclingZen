namespace CyclingZone.Web.ViewModels.Articles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using CyclingZone.Data.Models;
    using CyclingZone.Services.Mapping;
    using CyclingZone.Web.ViewModels.Home;
    using Ganss.XSS;

    public class ArticleViewModel : IMapFrom<Article>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Author { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ImageUrl { get; set; }

        public string Content { get; private set; }

        public int SubcategoryId { get; set; }

        public string Category { get; set; }

        public string Subcategory { get; set; }

        public string SanitizedContent => new HtmlSanitizer().Sanitize(this.Content);

        // Set to controller
        public IEnumerable<IndexArticleViewModel> Articles { get; set; }
    }
}
