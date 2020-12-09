namespace CyclingZone.Web.ViewModels.Home
{
    using CyclingZone.Data.Models;
    using CyclingZone.Services.Mapping;

    public class IndexArticleViewModel : IMapFrom<Article>
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string ShortTitle { get; set; }

        public int SubcategoryId { get; set; }
    }
}
