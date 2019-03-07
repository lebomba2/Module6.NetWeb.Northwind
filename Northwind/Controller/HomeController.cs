using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class HomeController : Controller
    {
        // private field 
        private INorthwindRepository repository;
        // lambda constructor setting repo field to repository
        public HomeController(INorthwindRepository repo) => repository = repo;

        // lambda expression that passes an IQueryable object 
        // to the view using Linq and another lambda expression
        public IActionResult Index() => View(repository.Categories.OrderBy(c => c.CategoryName));
    }
}