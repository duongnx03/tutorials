using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Client.Controllers
{
    public class ImageController : Controller
    {
        IHttpClientFactory factory;
        const string uri = "https://localhost:7011/api/upload/";

        public ImageController(IHttpClientFactory factory)
        {
            this.factory = factory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile image)
        {
            if(image == null && image.Length == 0)
            {
                return Content("File is not selected!");
            }
            HttpClient client = new HttpClient();
            byte[] data;
            using(var br = new BinaryReader(image.OpenReadStream()))
            {
                data = br.ReadBytes((int)image.OpenReadStream().Length);
            }

            ByteArrayContent bytes = new ByteArrayContent(data);
            MultipartFormDataContent multipart = new MultipartFormDataContent
            {
                {bytes, "file", image.FileName }
            };
            var result = await client.PostAsync(uri + image.FileName, multipart);
            return RedirectToAction("Index");
        }
    }
}

