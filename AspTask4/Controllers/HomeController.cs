using AspTask4.Data;
using AspTask4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspTask4.Controllers
{
    public class HomeController : Controller
    {
     
       private readonly ProductDbContext _context;

        public HomeController(ProductDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList().Select(p =>
            {
                return new ProductViewModel
                {
                    Name=p.Name,
                    Price=p.Price,

                };
            });

            var categories = _context.Categories.ToList().Select(c =>
            {
                return new CategoryViewModel
                {
                    Title=c.Title,

                };
            });
            var vm = new ProductsListViewModel {
                Products=products,
                Categories=categories
            };
            return View(vm);
        }
    }
}