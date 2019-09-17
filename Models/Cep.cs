using System;
using System.Collections.Generic;

namespace apiCiee.Models
{
    public class Cep {
        public int id { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string regiao { get; set; }
    }
}