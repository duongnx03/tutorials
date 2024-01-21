using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
using Client.ModelStatic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class ProductController : Controller
    {
        HttpClient client = new HttpClient();
        string uri = "https://localhost:7286/api/product/";


        public IActionResult Index()
        {
            var result = client.GetStringAsync(uri).Result;
            var list = JsonConvert.DeserializeObject<IEnumerable<Product>>(result);
            return View(list);
        }

        public IActionResult AddCart(int id)
        {
            var cart = new Cart();
            cart.ProductId = id;
            cart.Quantity = 1;
            cart.UserId = UserStatic.userId;
            var result = client.PostAsJsonAsync(uri, cart).Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ViewBag.error = "Add Cart Fail";
            return Redirect("/Home/Error");
        }

      
        public IActionResult ShowCart()
        {
            var result = client.GetStringAsync(uri + "showCart/" + UserStatic.userId).Result;
            var listCart = JsonConvert.DeserializeObject<IEnumerable<Cart>>(result);
            return View(listCart);
        }

        public IActionResult DeleteCart(int cartId)
        {
            var result = client.DeleteAsync(uri + "deleteCart/" + cartId).Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("ShowCart");
            }
            return Redirect("/Home/Error");
        }
    }
}

