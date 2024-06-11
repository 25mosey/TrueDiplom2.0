using Diplom.Models;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractController : ControllerBase
    {
        private DiplomContext db;
        public ContractController(DiplomContext ctx)
        {
            db = ctx;
        }

        [HttpPost]
        public void SaveContract([FromBody] Contract contract)
        {
            if (contract != null)
            {
                db.Contracts.Add(contract);
                db.SaveChanges();
            }
        }
        [HttpGet]
        public IEnumerable<Contract> GetContracts()
        {
            return db.Contracts.ToList();
        }
        [HttpGet("{id}")]
        public IEnumerable<Contract> GetContracts(int id)
        {
            return db.Contracts.Where(p => p.PartnerId == id).ToList();
        }
    }
}
