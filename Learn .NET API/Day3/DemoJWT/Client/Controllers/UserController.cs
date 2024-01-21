using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client.Controllers
{
    public class UserController : Controller
    {
        HttpClient client = new HttpClient();
        string uri = "https://localhost:7206/api/Auth";

        public IActionResult Index()
        {
            return View();
        }
    }
}

