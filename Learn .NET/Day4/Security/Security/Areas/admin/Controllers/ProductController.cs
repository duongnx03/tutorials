using System;
using Microsoft.AspNetCore.Mvc;

namespace Security.Areas.Controllers
{
    [Area("admin")]
    [Route("admin/Product")]
    public class ProductController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

