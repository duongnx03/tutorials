using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client.Controllers
{
    public class NewController : Controller
    {
        private readonly string uri = "https://localhost:7109/api/new/";
        HttpClient client = new HttpClient();
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(tbNews news)
        {
            var result = client.PostAsJsonAsync(uri, news).Result;
            if(result != null)
            {
                ViewBag.message = "Success";
            }
            else
            {
                ViewBag.message = "Error";
            }
           
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(tbNews news)
        {
            var result = client.DeleteAsync(uri + news.NewsId).Result;
            if(result.IsSuccessStatusCode)
            {
                ViewBag.message = "Success!";
            }
            else
            {
                ViewBag.message = "error";
            }
            return View();
        }
        
    }
}

