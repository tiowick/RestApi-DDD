using RestApiModeloDDD.Aplication.DTOS;
using RestApiModeloDDD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Interface
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperListClientesDto(IEnumerable<Produto> produtos);

        ProdutoDto MapperDtoToEntity(Produto produto);
    }
}
