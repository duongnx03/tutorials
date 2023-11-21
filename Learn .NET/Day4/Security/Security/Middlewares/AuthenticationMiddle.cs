using System;
namespace Security.Middlewares
{
	public class AuthenticationMiddle
	{
		private readonly RequestDelegate next;

		public AuthenticationMiddle(RequestDelegate next)
		{
			this.next = next;
		}

		public Task InvokeAsync(HttpContext context)
		{
			var path = context.Request.Path;
            if (path != null && path.Value.StartsWith("/admin"))
			{
				if(context.Session.GetString("username") == null)
				{
					context.Response.Redirect("/login");
				}
			}
			return next(context);
		}
	}

	//tao extension method de them middleware nay vao luong xu ly
	public static class AthenticationMiddlewareExtensions
	{
		public static IApplicationBuilder UseAuthenticationMiddleware(this IApplicationBuilder app)
		{
			return app.UseMiddleware<AuthenticationMiddle>();
		}
	}
}

