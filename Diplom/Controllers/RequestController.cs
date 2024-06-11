using Diplom.Models;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestController : ControllerBase
    {
        private DiplomContext db;
        public RequestController(DiplomContext ctx)
        {
            db = ctx;
        }

        [HttpPost]
        public void SaveRequest([FromBody] Request request)
        {
            if (request != null)
            {
                db.Requests.Add(request);
                db.SaveChanges();
            }
        }
        [HttpGet]
        public IEnumerable<Request> GetRequests()
        {
            return db.Requests.ToList();
        }
        [HttpGet("{id}")]
        public IEnumerable<Request> GetRequests(int id)
        {
            return db.Requests.Where(p => p.UserId == id).ToList();
        }
    }
}
