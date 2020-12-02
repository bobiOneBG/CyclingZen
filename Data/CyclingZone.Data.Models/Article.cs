namespace CyclingZone.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using CyclingZone.Data.Common.Models;

    public class Article : BaseDeletableModel<int>
    {
        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }

        public string Content { get; set; }

        public int CategoryId { get; set; }

        public int SubcategoryId { get; set; }
    }
}
