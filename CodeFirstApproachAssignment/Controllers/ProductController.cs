using Microsoft.AspNetCore.Mvc;
using CodeFirstApproachAssignment.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace CodeFirstApproachAssignment.Controllers
{
   
        public class ProductController : Controller
        {
            private ApplicationDbContext _context;

            public ProductController(ApplicationDbContext context)
            {
            _context = context;
            }
        public IActionResult Index()
        {
            var products = _context.Products.Select(p => new
            {
                Id = p.ProductId,
                Name = p.Name,
                Price = p.Price,
                Image = p.Image,
                Quantity = p.AvailableQuantity,
                BrandName = p.Brand.Name,
                CategoryName = p.Category.Name,
                Date = p.ProductAddedDate,
            }).ToList();
            return View(products);
        }
        public IActionResult ViewDetails(int id)
        {
            var products = _context.Products.Where(p => p.ProductId == id).Select(p => new
            {
                Id = p.ProductId,
                Name = p.Name,
                Price = p.Price,
                Image = p.Image,
                Quantity = p.AvailableQuantity,
                BrandName = p.Brand.Name,
                CategoryName = p.Category.Name,
                Date = p.ProductAddedDate,
            }).ToList();
            ViewBag.Result = products;
            return View(products);
        }
    }
}

