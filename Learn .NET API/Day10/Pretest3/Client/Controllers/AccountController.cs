using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Pretest3.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client.Controllers
{
    public class AccountController : Controller
    {
        private readonly string uri = "https://localhost:7195/api/account/";
        HttpClient client = new HttpClient();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Login(string username, string password)
        {
            var result = client.GetStringAsync(uri + "login/" + username + "/" + password).Result;
            var acc = JsonConvert.DeserializeObject<Account>(result);
            if (acc != null)
            {
                HttpContext.Session.SetString("username", acc.Username);
                HttpContext.Session.SetString("balance", acc.Balance.ToString());
                return RedirectToAction("Transaction");
            }
            ViewBag.error = "Login fail!";
            return View("Index");
        }

        public IActionResult Transaction()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Transaction(int amount, string withdraw, string deposit)
        {
            try
            {
                var username = HttpContext.Session.GetString("username");
                var balance = HttpContext.Session.GetInt32("balance");


                if (!int.TryParse(amount.ToString(), out int parsedAmount))
                {
                    ViewBag.error = "Invalid amount format";
                    return View();
                }

                if (balance == null || !int.TryParse(balance.ToString(), out int currentBalance))
                {
                    ViewBag.error = "Invalid balance format";
                    return View();
                }

                if (withdraw != null)
                {
                    if (currentBalance >= parsedAmount)
                    {
                        var result = await client.GetStringAsync($"{uri}withdraw/{username}/{parsedAmount}");
                        var isSuccess = JsonConvert.DeserializeObject<bool>(result);

                        if (isSuccess)
                        {
                            currentBalance -= parsedAmount;
                            HttpContext.Session.SetInt32("balance", currentBalance);
                        }
                        else
                        {
                            ViewBag.error = "Withdraw failed!";
                        }
                    }
                    else
                    {
                        ViewBag.error = "Insufficient balance for Withdraw!";
                    }
                }
                else if (deposit != null)
                {
                    var result = await client.GetStringAsync($"{uri}deposit/{username}/{parsedAmount}");
                    var isSuccess = JsonConvert.DeserializeObject<bool>(result);

                    if (isSuccess)
                    {
                        currentBalance += parsedAmount;
                        HttpContext.Session.SetInt32("balance", currentBalance);
                    }
                    else
                    {
                        ViewBag.error = "Deposit failed!";
                    }
                }

                return View();
            }
            catch (Exception ex)
            {
                ViewBag.error = "An error occurred during the transaction. Please try again.";
                return View();
            }
        }


    }
}


