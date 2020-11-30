namespace CyclingZone.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using CyclingZone.Data.Common.Models;

    public class Subcategory : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public int CategoryId { get; set; }
    }
}
