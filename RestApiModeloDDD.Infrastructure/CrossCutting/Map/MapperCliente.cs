using RestApiModeloDDD.Aplication.DTOS;
using RestApiModeloDDD.Domain.Entity;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Map
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public ClienteDto MapperDtoToEntity(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            throw new NotImplementedException();
        }
    }
}
