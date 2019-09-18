using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiCiee.Data;
using apiCiee.Models;
using apiCiee.ViewModels.EstudanteViewModels;

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

        [Route("api/estudantes/cpf/{cpf}")]
        [HttpGet]
        public Estudante Get(string cpf){
            return _context.Estudante
                .AsNoTracking()
                .Where(x => x.cpf == cpf)
                .FirstOrDefault();
        }

        [Route("api/estudantes/email/{email}")]
        [HttpGet]
        public Estudante GetEmail(string email){
            return _context.Estudante.AsNoTracking().Where(x => x.email == email).FirstOrDefault();
        }

        [Route("api/estudantes")]
        [HttpPost]

        public ResultViewModel Post([FromBody]EditorEstudanteViewModel model) {
            model.Validate();
            if(model.Invalid)
                return new ResultViewModel {
                    Success = false,
                    Message = "Não foi possível realizar o cadastro!",
                    Data = model.Notifications
                };
            
            var estudante = new Estudante();
            estudante.nome = model.nome;
            estudante.curso_id = model.curso_id;
            estudante.dt_cadastro = model.dt_cadastro;
            estudante.escola_id = model.escola_id;
            estudante.estagiario_ativo = model.estagiario_ativo;
            estudante.periodoano = model.periodoano;
            estudante.previsaoformatura = model.previsaoformatura;
            

            _context.Estudante.Add(estudante);
            _context.SaveChanges();

            return new ResultViewModel {
                Success = true,
                Message = "Cadastro realizado com sucesso!",
                Data = estudante
            };
        }
    }
}