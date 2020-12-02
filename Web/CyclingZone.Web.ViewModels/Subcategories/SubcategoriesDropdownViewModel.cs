namespace CyclingZone.Web.ViewModels.Subcategories
{
    using CyclingZone.Data.Models;
    using CyclingZone.Services.Mapping;

    public class SubcategoriesDropdownViewModel : IMapFrom<Subcategory>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }
    }
}
