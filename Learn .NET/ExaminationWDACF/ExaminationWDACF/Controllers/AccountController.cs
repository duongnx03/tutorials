using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExaminationWDACF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExaminationWDACF.Controllers
{
    public class AccountController : Controller
    {
        private readonly DatabaseContext db;

        public AccountController(DatabaseContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var account = await db.Accounts.SingleOrDefaultAsync(a => a.AccountNo == username && a.PinCode == password);
            if (account != null)
            {
                if (account.Role)
                {
                    // Redirect to AccountList page
                    return RedirectToAction("AccountList");
                }
                else
                {
                    // Redirect to AccountDetails page
                    return RedirectToAction("AccountDetails", new { accountNo = account.AccountNo });
                }
            }
            else
            {
                ViewBag.error = "Invalid AccountNo or Pin";
                return View("Index");

            }
        }

        public IActionResult AccountList()
        {
            var accounts = db.Accounts.Where(a => !a.Role).ToList();
            return View(accounts);
        }

        public IActionResult AccountDetails(string accountNo)
        {
            var account = db.Accounts.FirstOrDefault(a => a.AccountNo == accountNo);
            return View(account);
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Registration(Account account)
        {
            // Kiểm tra xem AccountNo đã tồn tại hay chưa
            var existingAccount = db.Accounts.FirstOrDefault(a => a.AccountNo == account.AccountNo);

            if (existingAccount != null)
            {
                // Trả về trang đăng ký với thông báo lỗi
                ViewBag.error = "AccountNo already exists.";
                return View();
            }

            // Thêm bản ghi mới
            db.Accounts.Add(account);
            await db.SaveChangesAsync();

            // Chuyển hướng đến trang danh sách tài khoản sau khi đăng ký thành công
            return RedirectToAction("AccountList");
        }

    }
}

