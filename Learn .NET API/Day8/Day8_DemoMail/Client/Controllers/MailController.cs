using Client.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client.Controllers
{
    public class MailController : Controller
    {
        string uri = "https://localhost:7134/api/mail";
        HttpClient client = new HttpClient();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Index(MailRequest mailRequest)
        {
            var formDataContent = new MultipartFormDataContent();
            foreach (var attachment in mailRequest.Attachments)
            {
                var fileContent = new StreamContent(attachment.OpenReadStream())
                {
                    Headers =
                    {
                        ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(attachment.ContentType)
                    }
                };
                formDataContent.Add(fileContent, "Attachments", attachment.ContentType);
            }
                formDataContent.Add(new StringContent(mailRequest.ToEmail), "ToEmail");
                formDataContent.Add(new StringContent(mailRequest.Subject), "Subject");
                formDataContent.Add(new StringContent(mailRequest.Body), "Body");

                var response = await client.PostAsync(uri, formDataContent);
                if (response.IsSuccessStatusCode)
                {
                    return Content("Success!");
                }
            

            return View();
        }
    }
}

