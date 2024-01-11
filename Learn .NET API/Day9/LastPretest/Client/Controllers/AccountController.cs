using LastPretest.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class AccountController : Controller
    {
        private readonly string uri = "https://localhost:7109/api/Account/";
        HttpClient client = new HttpClient();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var result = client.GetStringAsync(uri + "login/" + username + "/" + password).Result; 
            var acc = JsonConvert.DeserializeObject<Account>(result);   
            if(acc != null)
            {
                HttpContext.Session.SetString("username", acc.Username);
                HttpContext.Session.SetString("balance", acc.Balance.ToString());
                return RedirectToAction("Transaction");
            }
            ViewBag.error = "Login fail";
            return View("Index");
        }

        public IActionResult Transaction()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Transaction(int amount, string Withdraw, string Deposit)
        {
            return View();
        }


    }
}
