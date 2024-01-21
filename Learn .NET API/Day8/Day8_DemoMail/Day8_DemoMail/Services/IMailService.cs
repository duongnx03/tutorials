using Day8_DemoMail.Models;

namespace Day8_DemoMail.Services
{
    public interface IMailService
    {
        Task SendMailAsync(MailRequest mailRequest);
    }
}
