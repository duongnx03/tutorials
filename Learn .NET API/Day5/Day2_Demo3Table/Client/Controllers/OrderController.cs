using Newtonsoft.Json;
using Client.Models;
using Client.ModelStatic;
using Microsoft.AspNetCore.Mvc;


namespace Client.Controllers
{
    public class OrderController : Controller
    {
        HttpClient client = new HttpClient();
        string uri = "https://localhost:7120/api/Order/";
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Order order)
        {
            order.OrderDate = DateTime.Now;
            order.UserId = UserStatic.userId;
            var result = client.PostAsJsonAsync(uri, order).Result;
            if (result.IsSuccessStatusCode)
            {
                //add order thanh cong
                return RedirectToAction("ListOrder");
            }
            return Redirect("/Home/Error");
        }

        public IActionResult ListOrder()
        {
            var result = client.GetStringAsync(uri + UserStatic.userId).Result;
            var list = JsonConvert.DeserializeObject<IEnumerable<Order>>(result);
            return View(list);
        }

        public IActionResult Details(int orderId)
        {
            var result = client.GetStringAsync(uri + "Details/" + orderId).Result;
            var order = JsonConvert.DeserializeObject<Order>(result);
            return View(order.Details);
        }
    }
}

