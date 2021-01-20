namespace CyclingZone.Data.Models.ForumModels
{
    using System.Collections.Generic;

    using CyclingZone.Data.Common.Models;

    public class ForumCategory : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
