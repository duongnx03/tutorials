using System;
using Authorize.Models;
using Authorize.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Authorize.Controllers
{
	public class AccountController : Controller
	{
		private readonly DemoAuthorizeContext db;
		SecurityManager securityManager = new SecurityManager();

		public AccountController(DemoAuthorizeContext db)
		{
			this.db = db;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> Login(string username, string password)
		{
			var account = await ProcessLogin(username, password);
			{
				if (account == null)
				{
					ViewBag.error = "Invalid username or password";
					return View("Index");
				}
				else
				{
					await securityManager.SignIn(this.HttpContext, account);
					return RedirectToAction("Welcome");
				}
			}
		}

		[NonAction]

		private async Task<Account> ProcessLogin(string username, string password)
		{
			var account = await db.Accounts.Include(a => a.AccountRoles).ThenInclude(a => a.Role).SingleOrDefaultAsync(a => a.Username == username);
			if(account != null)
			{
				if(BCrypt.Net.BCrypt.Verify(password, account.Password))
				{
					return account;
				}
			}
			return null;
		}

		public IActionResult Welcome()
		{
			return View();
		}

		public IActionResult AccessDinied()
		{
			return View();
		}

		public async Task<IActionResult> SignOut()
		{
			await securityManager.SignOut(this.HttpContext);
			return RedirectToAction("Index");
		}
	}
}

