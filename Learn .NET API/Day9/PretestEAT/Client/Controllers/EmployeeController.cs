using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client.Controllers
{
    public class EmployeeController : Controller
    {
        string uri = "https://localhost:7229/api/employee/";
        HttpClient client = new HttpClient();


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var result = client.GetStringAsync(uri + "checkLogin/" + username + "/" + password).Result;
            var resultLogin = JsonConvert.DeserializeObject<bool>(result);

            if (resultLogin)
            {
                return RedirectToAction("Search");
            }
            ViewBag.error = "Login fail!";
            return View("Index");
           
        }


        public IActionResult Search(float min, float max)
        {
            if (min == 0 || max == 0)
            {
                max = 10000;
            }
            var result = client.GetStringAsync(uri + "findAll/" + min + "/" + max).Result;
            var list = JsonConvert.DeserializeObject<IEnumerable<Employee>>(result);
            return View(list);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            Employee employee = new Employee();
            employee.EmpID = id;
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee employee)
        {
            var result = client.GetStringAsync(uri + "update/" + employee.EmpID + "/" + employee.Salary).Result;
            var resultUpdate = JsonConvert.DeserializeObject<bool>(result);
            if (resultUpdate)
            {
                return Content("Update Success!");
            }
            return Content("Update fail!");
        }
    }
}

