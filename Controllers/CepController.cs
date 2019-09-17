using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiCiee.Data;
using apiCiee.Models;

namespace apiCiee.Controllers 
{
    public class CepController : Controller {
        private readonly StoreDataContext _context;

        public CepController(StoreDataContext context) => _context = context;

        [Route("api/cep")]
        [HttpGet]
        public IEnumerable<Cep> GetCeps() {
            return _context.Cep.AsNoTracking().ToList();
        }

        [Route("api/cep/{cep}")]
        [HttpGet]
        public Cep GetCep(string cep){
            return _context.Cep.AsNoTracking().Where(x => x.cep == cep).FirstOrDefault();
        }
    }
}