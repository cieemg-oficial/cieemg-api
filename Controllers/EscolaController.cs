using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiCiee.Data;
using apiCiee.Models;

namespace apiCiee.Controllers 
{
    public class EscolaController : Controller {
        private readonly StoreDataContext _context;

        public EscolaController(StoreDataContext context) => _context = context;

        [Route("api/escolas")]
        [HttpGet]
        public IEnumerable<Escola> GetEscolas(){
            return _context.Escolas.AsNoTracking().ToList();
        }

        [Route("api/escolas/{id}")]
        [HttpGet]
        public Escola Get(int id){
            return _context.Escolas.AsNoTracking().Where(x=> x.id == id).FirstOrDefault();
        }
    }
}