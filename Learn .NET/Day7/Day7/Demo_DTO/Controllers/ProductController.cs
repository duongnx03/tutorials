using System;
using AutoMapper;
using Demo_DTO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo_DTO.Controllers
{
      public class ProductController : Controller
    {
        private readonly IMapper mapper;

        private readonly ProductContext db;

        public ProductController(IMapper mapper, ProductContext db)
        {
            this.mapper = mapper;
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {
            var productsdb = await db.Products.ToListAsync();
            var productsDTO = mapper.Map<List<ProductDTO>>(productsdb);
            return View(productsDTO);
        }
    }
}

