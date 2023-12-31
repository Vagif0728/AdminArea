﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plonaria.DAL;
using Plonaria.Models;
using Plonaria.VİewModels;

namespace ProniaAB104.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private Product product;
        private List<Product> products;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            //if (id <= 0) return BadRequest();

            //Product product = _context.Products
            //    .Include(p => p.Category)
            //    .Include(p => p.ProductImages)
            //    .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
            //    .FirstOrDefault(p => p.Id == id);



            //if (product is null) return NotFound();

            //List<Product> products = _context.Products
            //    .Include(p => p.ProductImages.Where(pi => pi.IsPrimary != null))
            //    .Where(p => p.CategoryId == product.CategoryId && p.Id != product.Id)
            //    .ToList();

            DetailVM detailVM = new DetailVM
            {
                Product = product,
                RelatedProducts = products,
            };

            return View(detailVM);
        }
    }
}