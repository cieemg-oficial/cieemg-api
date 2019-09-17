using System;
using System.Collections.Generic;

namespace apiCiee.Models
{
    public class Curso {
        public int id { get; set; }
        public int idescola { get; set; }
        public int idcurso { get; set; }
        public string descricao { get; set; }
        public string  duracao { get; set; }
    }
}