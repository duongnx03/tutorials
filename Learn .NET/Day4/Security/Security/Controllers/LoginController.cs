using System;
using Microsoft.AspNetCore.Mvc;

namespace Security.Controllers
{
	//[Route("Dangnhap")]
	public class LoginController : Controller
	{
        public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
        public IActionResult CheckLogin(string username, string password)
		{
			if("aptech" == username && "123" == password)
			{
				HttpContext.Session.SetString("username", username);
				//return View("Welcome");
				return Redirect("/admin/Product");
			}
			else
			{
				ViewBag.error = "Invalid username or password";
				return View("Index");
			}
		}
	}
}

