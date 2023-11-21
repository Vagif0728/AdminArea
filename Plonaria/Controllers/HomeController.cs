using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plonaria.DAL;
using Plonaria.Models;
using Plonaria.VİewModels;

namespace Plonaria.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private List<Product> products;
        private List<Slide> slides;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {


            //List<Slide> slides = _context.Slides.OrderBy(s => s.Order).Take(2).ToList();

            //List<Product> products = _context.Products.Include(p => p.ProductImages.Where(pi => pi.IsPrimary != null)).ToList();
            //_context.Slides.AddRange(slides);
            //_context.SaveChanges();

            HomeVM home = new HomeVM
            {
                Slides = slides,
                Products = products
            };


            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}