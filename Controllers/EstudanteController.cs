using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiCiee.Data;
using apiCiee.Models;

namespace apiCiee.Controllers
{
    public class EstudanteController : Controller {
        private readonly StoreDataContext _context;

        public EstudanteController(StoreDataContext context) => _context = context;

        [Route("api/estudantes")]
        [HttpGet]
        public IEnumerable<Estudante> GetEstudantes() {
            return  _context.Estudante.AsNoTracking().ToList();
        }

        [Route("api/estudantes/{cpf}")]
        [HttpGet]
        public Estudante Get(string cpf){
            return _context.Estudante.AsNoTracking().Where(x => x.cpf == cpf).FirstOrDefault();
        }

        [Route("api/estudantes/email/{email}")]
        [HttpGet]
        public Estudante GetEmail(string email){
            return _context.Estudante.AsNoTracking().Where(x => x.email == email).FirstOrDefault();
        }
    }
}