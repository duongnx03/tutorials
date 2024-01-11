using Microsoft.AspNetCore.Mvc;
using Student1427717.Models;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client.Controllers
{
    public class EmployeeController : Controller
    {
        string uri = "https://localhost:7130/api/employee/";
        HttpClient client = new HttpClient();

        public IActionResult Index()
        {
           
            return View();
        }



        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Login(string username, string password)
        {
            var result = client.GetStringAsync(uri + "checkLogin/" + username + "/" + password).Result;
            var resultLogin = JsonConvert.DeserializeObject<bool>(result);

            if (resultLogin)
            {
                return RedirectToAction("Index");
            }
            ViewBag.error = "Login fail!";
            return View("Login");
        }

        public IActionResult Edit(string employeeName)
        {
            var result = client.GetStringAsync(uri + employeeName).Result;
            var emp = JsonConvert.DeserializeObject<Employee>(result);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var result = client.PutAsJsonAsync(uri, employee).Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        
        
    }
}

