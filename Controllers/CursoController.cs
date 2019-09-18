using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiCiee.Data;
using apiCiee.Models;

namespace apiCiee.Controllers
{
    public class CursoController : Controller {
        private readonly StoreDataContext _context;

        public CursoController(StoreDataContext context) => _context = context;

        [Route("api/cursos")]
        [HttpGet]
        public IEnumerable<Curso> GetCursos() {
            return _context.Curso.AsNoTracking().ToList();
        }

        [Route("api/cursos/{id}")]
        [HttpGet]
        public Curso GetCurso(int id) {
            return _context.Curso.AsNoTracking().Where(x => x.id == id).FirstOrDefault();
        }

        [Route("api/cursos/escola/{idescola}")]
        [HttpGet]
        public IEnumerable<Curso> GetCursosEscola(int idescola){
            return _context.Curso.AsNoTracking().Where(x => x.idescola == idescola).ToList();
        }
    }
}