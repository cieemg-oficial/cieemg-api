using System;
using System.Collections.Generic;

namespace apiCiee.Models
{
    public class Escola {
        public int id { get; set; }
        public string razaosocial {get; set;}
        public string cnpj { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string nomecontato { get; set; }
        public string email { get; set; }
        public int importado { get; set; }
        public string senha { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string codescola { get; set; }
    }
}