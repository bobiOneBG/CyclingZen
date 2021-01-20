namespace CyclingZone.Data.Models.ForumModels
{
    using CyclingZone.Data.Common.Models;

    public class ForumCategory : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }
    }
}
