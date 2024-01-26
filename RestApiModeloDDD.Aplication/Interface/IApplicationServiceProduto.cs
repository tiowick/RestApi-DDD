using RestApiModeloDDD.Aplication.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Aplication.Interface
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);

        void Update(ProdutoDto produtoDto);

        void Remove(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> GetAll();

        ProdutoDto GetById(int id);
    }
}

