using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class ProductController : Controller
    {
        string uri = "https://localhost:7279/api/product/";

        HttpClient client = new HttpClient();

        public IActionResult Index()
        {
            var result = client.GetStringAsync(uri).Result;
            var list = JsonConvert.DeserializeObject<IEnumerable<Product>>(result);
            return View(list);
        }

        public IActionResult Create(Product product)
        {
            var result = client.PostAsJsonAsync(uri, product).Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        
    }
}