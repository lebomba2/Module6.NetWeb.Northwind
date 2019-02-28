using System;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}