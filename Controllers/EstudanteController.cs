using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiCiee.Data;
using apiCiee.Models;
using apiCiee.ViewModels;
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

        public ResultViewModel Post([FromBody]CreateEstudanteViewModel model) {
            model.Validate();
            if(model.Invalid)
                return new ResultViewModel {
                    Success = false,
                    Message = "Não foi possível realizar o cadastro!",
                    Data = model.Notifications
                };
            
            var estudante = new Estudante();
            estudante.nome = model.nome;
            estudante.cpf = model.cpf;
            estudante.logradouro = model.logradouro;
            estudante.numero = model.numero;
            estudante.complemento = model.complemento;
            estudante.cep = model.cep;
            estudante.telefone = model.telefone;
            estudante.email = model.email;
            estudante.cidade = model.cidade;
            estudante.bairro = model.bairro;
            estudante.senha = model.senha;
            estudante.nomepai = model.nomepai;
            estudante.nomemae = model.nomemae;
            estudante.estadocivil = model.estadocivil;
            estudante.sexo = model.sexo;
            estudante.dt_nascimento = model.dt_nascimento;
            estudante.horario = model.horario;
            estudante.rg = model.rg;
            estudante.orgaoexpedidor = model.orgaoexpedidor;
            estudante.periodoano = model.periodoano;
            estudante.previsaoformatura = model.previsaoformatura;
            estudante.curso_id = model.curso_id;
            estudante.escola_id = model.escola_id;
            estudante.dt_cadastro = model.dt_cadastro;
            estudante.uf = model.uf;
            estudante.idade = model.idade;
            estudante.estagiario_ativo = model.estagiario_ativo;
            estudante.dt_atualizacao = model.dt_atualizacao;
            estudante.periodo = model.periodo;
            estudante.ano = model.ano;
            estudante.previsao_semestre = model.previsao_semestre;
            estudante.previsao_ano = model.previsao_ano;
            estudante.previsao_mes = model.previsao_mes;
            estudante.deficiencia = model.deficiencia;
            estudante.deficiencia_descricao = model.deficiencia_descricao;
            estudante.telefone1 = model.telefone1;
            estudante.telefone2 = model.telefone2;
            estudante.ctps = model.ctps;
            // estudante.candidato_selecionado = model.candidato_selecionado;
            // estudante.anoingresso = model.anoingresso;
            // estudante.semestreingresso = model.semestreingresso;
            // estudante.cpf_pai = model.cpf_pai;
            // estudante.cpf_mae = model.cpf_mae;
            // estudante.notificacao = model.notificacao;
            // estudante.dt_alteracao_notificacao = model.dt_alteracao_notificacao;


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