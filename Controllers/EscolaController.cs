using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiCiee.Data;
using apiCiee.Models;
using apiCiee.ViewModels.EscolaViewModels;

namespace apiCiee.Controllers 
{
    public class EscolaController : Controller {
        private readonly StoreDataContext _context;

        public EscolaController(StoreDataContext context) => _context = context;

        [Route("api/escolas")]
        [HttpGet]
        public IEnumerable<ListEscolaViewModel> GetEscolas(){
            return _context.Escolas.Select(x => new ListEscolaViewModel {
                id = x.id,
                razaosocial = x.razaosocial
            }).AsNoTracking().ToList();
        }

        [Route("api/escolas/{id}")]
        [HttpGet]
        public Escola Get(int id){
            return _context.Escolas.AsNoTracking().Where(x=> x.id == id).FirstOrDefault();
        }
    }
}