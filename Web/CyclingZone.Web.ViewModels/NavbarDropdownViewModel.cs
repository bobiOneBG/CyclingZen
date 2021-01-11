namespace CyclingZone.Web.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CyclingZone.Data.Models;
    using CyclingZone.Services.Mapping;
    using CyclingZone.Web.ViewModels.Subcategories;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class NavbarDropdownViewModel : IMapFrom<Subcategory>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<SubcategoriesDropdownViewModel> Subcategories { get; set; }

        public IEnumerable<SelectListItem> SelectSubcategories => this.Subcategories?
            .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
    }
}
