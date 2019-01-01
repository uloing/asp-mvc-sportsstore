﻿using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SportsStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
