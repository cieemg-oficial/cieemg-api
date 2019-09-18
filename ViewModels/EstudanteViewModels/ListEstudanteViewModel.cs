using System;
using System.Collections.Generic;

namespace apiCiee.ViewModels.EstudanteViewModels
{
    public class ListEstudanteViewModel {
        public int? id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string nomepai { get; set; }
        public string nomemae { get; set; }
        public string estadocivil { get; set; }
        public string sexo { get; set; }
        public DateTime?  dt_nascimento { get; set; }
        public string horario { get; set; }
        public string rg { get; set; }
        public string orgaoexpedidor { get; set; }
        public string periodoano { get; set; }
        public string previsaoformatura { get; set; }
        public int? curso_id { get; set; }
        public int? escola_id { get; set; }
        public DateTime? dt_cadastro { get; set; }
        public string uf { get; set; }
        public int? idade { get; set; }
        public string estagiario_ativo { get; set; }
        public DateTime? dt_atualizacao { get; set; }
        public Int32? periodo { get; set; }
        public int? ano { get; set; }
        public Int32? previsao_semestre { get; set; }
        public int? previsao_ano { get; set; }
        public Int32? previsao_mes { get; set; }
        public string deficiencia { get; set; }
        public string deficiencia_descricao { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string ctps { get; set; }
        public int? candidato_selecionado { get; set; }
        public int? anoingresso { get; set; }
        public int? semestreingresso { get; set; }
        public string cpf_pai { get; set; }
        public string cpf_mae { get; set; }
        public string notificacao { get; set; }
        public DateTime? dt_alteracao_notificacao { get; set; }
    }
}