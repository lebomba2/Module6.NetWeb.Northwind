using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Models;

namespace Northwind.Core.Controllers
{
    public class ProductController : Controller
    {
        // this controller depends on the BloggingRepository
        private INorthwindRepository repository;
        public ProductController(INorthwindRepository repo) => repository = repo;

        // Category method passing the Category table, sorted by the CategoryName, to the Category View
        public IActionResult Category() => View(repository.Categories.OrderBy(c => c.CategoryName));
        // CategoryDetail method passing the Products table, filtered by CategoryId and Discontinued, ordered by ProductName
        public IActionResult CategoryDetail(int id) => View(repository.Products.Where(p => p.CategoryId == id && p.Discontinued == false).OrderBy(p => p.ProductName));
    }
}