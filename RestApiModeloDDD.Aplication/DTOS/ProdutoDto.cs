using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Aplication.DTOS
{
    public class ProdutoDto
    {
        public int Id { get; set; }

        public string Nome { get; set;}

        public decimal Valor { get; set; }
    }
}
