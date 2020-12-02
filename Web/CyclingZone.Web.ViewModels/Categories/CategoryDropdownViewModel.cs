namespace CyclingZone.Web.ViewModels.Categories
{
    using CyclingZone.Data.Models;
    using CyclingZone.Services.Mapping;

    public class CategoryDropdownViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
