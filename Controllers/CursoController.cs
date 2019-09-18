using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiCiee.Data;
using apiCiee.Models;
using apiCiee.ViewModels.CursoViewModels;

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
        public IEnumerable<ListCursoViewModel> GetCursosEscola(int idescola){
            return _context.Curso.Select(
                x => new ListCursoViewModel {
                    idescola = x.idescola,
                    idcurso = x.idcurso,
                    descricao = x.descricao,
                    duracao = x.duracao
                }
            ).AsNoTracking().Where(x => x.idescola == idescola).ToList();
        }
    }
}