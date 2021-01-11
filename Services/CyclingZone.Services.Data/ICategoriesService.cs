﻿namespace CyclingZone.Services.Data
{
    using System.Collections.Generic;

    public interface ICategoriesService
    {
        IEnumerable<T> GetAll<T>();
    }
}
