namespace CyclingZone.Web.ViewModels.ForumHome
{
    using CyclingZone.Data.Models.ForumModels;
    using CyclingZone.Services.Mapping;

    public class IndexForumCategoryViewModel : IMapFrom<ForumCategory>
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public int PostsCount { get; set; }
    }
}
