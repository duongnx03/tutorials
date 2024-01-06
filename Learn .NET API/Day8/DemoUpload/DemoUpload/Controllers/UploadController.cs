using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoUpload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        IWebHostEnvironment env;
        public UploadController(IWebHostEnvironment env)
        {
            this.env = env;
        }

        [HttpPost("{filename}")]
        public async Task<IActionResult> PostUpload(string filename)
        {
            var upload = Path.Combine(env.ContentRootPath, "Images");
            var filePath = Path.Combine(upload, filename);
            if (Request.HasFormContentType)
            {
                var form = Request.Form;
                foreach(var field in form.Files)
                {
                    using(var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await field.CopyToAsync(stream);
                    }
                }
            }
            return Ok(new { Path = filePath });
        }
    }
}

