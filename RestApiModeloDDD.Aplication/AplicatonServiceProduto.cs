using RestApiModeloDDD.Aplication.DTOS;
using RestApiModeloDDD.Aplication.Interface;
using RestApiModeloDDD.Domain.Core.Interface.Services;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interface;
using RestApiModeloDDD.Infrastructure.CrossCutting.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Aplication
{
    public class AplicatonServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapperProduto mapperProduto;
        public AplicatonServiceProduto(
            IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }


        public void Add(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produto = serviceProduto.GetAll();
            return mapperProduto.MapperListClientesDto(produto);

        }

        public ProdutoDto GetById(int id)
        {
            var produto = serviceProduto.GetById(id);
            return mapperProduto.MapperDtoToEntity(produto);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Update(produto);
        }
    }
}
