using RestApiModeloDDD.Aplication.DTOS;
using RestApiModeloDDD.Aplication.Interface;
using RestApiModeloDDD.Domain.Core.Interface.Services;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Aplication 
{
    //
    public class AplicatonServiceCliente : IApplicationServiceCliente
    {

        private readonly IServiceCliente serviceCliente;
        private readonly IMapperCliente mapperCliente;

        public AplicatonServiceCliente(
            IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            this.serviceCliente = serviceCliente;
            this.mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var cliente = serviceCliente.GetAll();
            return mapperCliente.MapperListClientesDto(cliente);
        }

        public ClienteDto GetById(int id)
        {
            var cliente = serviceCliente.GetById(id);
            return mapperCliente.MapperDtoToEntity(cliente);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Update(cliente);
            
        }
    }
}
