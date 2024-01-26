using RestApiModeloDDD.Aplication.DTOS;
using RestApiModeloDDD.Domain.Entity;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                //entidades PrdotudoDto
                Id = produtoDto.Id,
                nome = produtoDto.Nome,
                valor= produtoDto.Valor

            };
            return produto;
        }

        public ProdutoDto MapperDtoToEntity(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                //entidades PrdotudoDto
                Id = produto.Id,
                Nome = produto.nome,
                Valor = produto.valor
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListClientesDto(IEnumerable<Produto> produtos)
        {                                                //entidades PrdotudoDto               
            var dto = produtos.Select(c => new ProdutoDto{Id = c.Id 
                                                          ,Nome = c.nome
                                                          ,Valor = c.valor});
            return dto;
        }
    }
}
