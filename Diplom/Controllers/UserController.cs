using Diplom.Models;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private DiplomContext db;
        public UserController(DiplomContext ctx)
        {
            db = ctx;
        }
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return db.Users.ToList();
        }
        [HttpGet("{id}")]
        public IEnumerable<User> GetUsers(int id)
        {
            return db.Users.Where(p => p.UserId == id).ToList();
        }
    }
}
