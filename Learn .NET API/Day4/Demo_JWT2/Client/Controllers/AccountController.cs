using Client.Models;
using Client.StaticVariable;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client.Controllers
{
    public class AccountController : Controller
    {
        HttpClient client = new HttpClient();
        string uriAuth = "https://localhost:7159/api/Auth/";
        string uriProduct = "https://localhost:7159/api/Product/";

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var accountLogin = new AccountLogin { Email = username, Password = password };
            var result = client.PostAsJsonAsync(uriAuth, accountLogin).Result;
            if (result.IsSuccessStatusCode)
            {
                var response = JObject.Parse(result.Content.ReadAsStringAsync().Result);
                var token = response["token"].ToString();
                UserToken.Token = token;

                return RedirectToAction("List");
            }
            ViewBag.error = "Login Fail";
            return View("Index");
        }

        public IActionResult List()
        {
            var result = client.GetStringAsync(uriProduct).Result;
            var list = JsonConvert.DeserializeObject<IEnumerable<Product>>(result);
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + UserToken.Token);
            var result = client.PostAsJsonAsync(uriProduct, product).Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("List");
            }
            else if(result.StatusCode == System.Net.HttpStatusCode.Unauthorized)//401
            {
                ViewBag.error = "Pls Login";
                return View("Index");
            }
            else if(result.StatusCode == System.Net.HttpStatusCode.Forbidden)//403
            {
                ViewBag.error = "You not have permision";
            }
            return View("Index");
        }
    }
}

