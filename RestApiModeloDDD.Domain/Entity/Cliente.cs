using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Entity
{
    public class Cliente : Base
    {
        public string nome { get; set; }

        public string sobreNome { get; set; }

        public string email { get; set; }

        public DateTime dataCadastro { get; set; }

        public bool isAtivo { get; set; }
    }
}
