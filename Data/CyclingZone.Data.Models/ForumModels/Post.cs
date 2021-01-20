namespace CyclingZone.Data.Models.ForumModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using CyclingZone.Data.Common.Models;

    public class Post : BaseDeletableModel<int>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
