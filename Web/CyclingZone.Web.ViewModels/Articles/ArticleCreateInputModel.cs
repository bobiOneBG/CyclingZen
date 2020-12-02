namespace CyclingZone.Web.ViewModels.Articles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;

    using CyclingZone.Data.Models;
    using CyclingZone.Services.Mapping;
    using CyclingZone.Web.ViewModels.Categories;
    using CyclingZone.Web.ViewModels.Subcategories;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class ArticleCreateInputModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Subtitle { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [MinLength(10)]
        public string Content { get; set; }

        [Range(1, int.MaxValue)]
        [Display(Name = "Subcategory")]
        public int SubcategoryId { get; set; }

        [Range(1, int.MaxValue)]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryDropdownViewModel> Categories { get; set; }

        public IEnumerable<SelectListItem> SelectCategories => this.Categories?
            .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });

        public IEnumerable<SubcategoriesDropdownViewModel> Subcategories { get; set; }

        public IEnumerable<SelectListItem> SelectSubcategories => this.Subcategories?
            .Select(x => new SelectListItem { Text = x.Name, Value = x.CategoryId.ToString() });
    }
}
