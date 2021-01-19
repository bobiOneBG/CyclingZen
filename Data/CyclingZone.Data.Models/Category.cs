namespace CyclingZone.Data.Models
{
    using System.Collections.Generic;

    using CyclingZone.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Articles = new HashSet<Article>();
        }

        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
