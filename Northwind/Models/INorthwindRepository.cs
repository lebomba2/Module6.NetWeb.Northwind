using System;
using System.Linq;
using Northwind.Models;

namespace Northwind.Models
{
    // Interface defining NorthwindRepository
    public interface INorthwindRepository
    {
        IQueryable<Category> Categories { get; }
        IQueryable<Product> Products { get; }

        // TODO: AddBlog, UpdateBlog, DeleteBlog
        // TODO: AddPost, UpdatePost, DeletePost
    }
}