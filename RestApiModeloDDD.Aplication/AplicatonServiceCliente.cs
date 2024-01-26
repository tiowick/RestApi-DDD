using RestApiModeloDDD.Aplication.DTOS;
using RestApiModeloDDD.Aplication.Interface;
using RestApiModeloDDD.Domain.Core.Interface.Services;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Aplication
{
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
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClienteDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public void Update(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }
    }
}
