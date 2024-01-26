using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Entity
{
    public class Produto : Base
    {
        public string nome { get; set; }

        public decimal valor { get; set; }

        public bool isDisponivel { get; set; }
    }
}
