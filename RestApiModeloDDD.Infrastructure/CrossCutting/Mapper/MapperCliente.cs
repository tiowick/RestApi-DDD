using RestApiModeloDDD.Aplication.DTOS;
using RestApiModeloDDD.Domain.Entity;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        //IEnumerable<ClienteDto> clienteDto = new List<ClienteDto>();

        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                // entidades ClienteDto
                Id = clienteDto.Id,
                nome = clienteDto.Nome,
                sobreNome = clienteDto.Sobrenome,
                email = clienteDto.Email
            };
            return cliente;
        }

        public ClienteDto MapperDtoToEntity(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                // entidades ClienteDto
                Id = cliente.Id,
                Nome = cliente.nome,
                Sobrenome = cliente.sobreNome,
                Email = cliente.email
            };
            return clienteDto; }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(c => new ClienteDto{ Id = c.Id
                                                             ,Nome = c.nome
                                                             ,Sobrenome = c.sobreNome
                                                             ,Email = c.email});
            return dto;
        }
    }
}
