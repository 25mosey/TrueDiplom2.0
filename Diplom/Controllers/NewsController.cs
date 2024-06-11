using Diplom.Models;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private DiplomContext db;
        public NewsController(DiplomContext ctx)
        {
            db = ctx;
        }

        [HttpPost]
        public void SaveNews([FromBody] News news)
        {
            if (news != null)
            {
                db.News.Add(news);
                db.SaveChanges();
            }
        }
        [HttpPut]
        public IEnumerable<News> News([FromBody] News news)
        {

            return db.News.ToList();
        }
        [HttpGet]
        public IEnumerable<News> GetNews()
        {
            return db.News.ToList();
        }
        
    }
}
