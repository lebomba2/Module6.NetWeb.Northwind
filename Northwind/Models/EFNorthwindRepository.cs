﻿using System;
using System.Linq;

namespace Northwind.Models
{
    // implementing the INorthwindRepository
    public class EFNorthwindRepository : INorthwindRepository
    {
        // the repository class depends on the BloggingContext service
        // which was registered at application startup
        private NorthwindContext context;
        public EFNorthwindRepository(NorthwindContext ctx)
        {
            context = ctx;
        }
        // create IQueryable for Blogs & Posts
        public IQueryable<Category> Categories => context.Categories;
        public IQueryable<Product> Products => context.Products;

    }
}