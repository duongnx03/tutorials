using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pretest2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pretest2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : ControllerBase
    {
        private readonly DatabaseContext db;

        public NewController(DatabaseContext db)
        {
            this.db = db;
        }

        [HttpPost]
        public async Task<bool> PostNews(tbNews News)
        {
            try
            {
                db.tbNews.Add(News);
                await db.SaveChangesAsync();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteNews(string id)
        {
            var news = await db.tbNews.SingleOrDefaultAsync(n => n.NewsId == id);
            if(news != null)
            {
                db.tbNews.Remove(news);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

    }
}

