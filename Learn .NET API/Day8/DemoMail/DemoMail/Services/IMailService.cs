using System;
using DemoMail.Models;

namespace DemoMail.Services
{
	public interface IMailService
	{
		Task SendMailAsync(MailRequest mailRequest);
	}
}

