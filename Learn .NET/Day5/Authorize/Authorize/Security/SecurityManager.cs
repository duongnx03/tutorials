using System;
using Authorize.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace Authorize.Security
{
	public class SecurityManager
	{
		private IEnumerable<Claim> GetUserClaims(Account account)
		{
			//claims se luu cac role cua account
			var claims = new List<Claim>();
			claims.Add(new Claim(ClaimTypes.Name, account.Username));

			//add role tuong ung voi username do
			account.AccountRoles.ToList().ForEach(ar =>
			{
				claims.Add(new Claim(ClaimTypes.Role, ar.Role.Name));
			});
			return claims;
		}

		public async Task SignIn(HttpContext context, Account account)
		{
			//cho phep dung cookie de dang nhap
			ClaimsIdentity claimsIdentity = new ClaimsIdentity(GetUserClaims(account),
				CookieAuthenticationDefaults.AuthenticationScheme);

			//quan ly thong tin account thong qua dinh danh claimsidentity
			//ko luu password
			ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
			await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
		}

		public async Task SignOut(HttpContext context)
		{
			await context.SignOutAsync();
		}
	}
}

