using Autofac;
using RestApiModeloDDD.Aplication;
using RestApiModeloDDD.Aplication.Interface;
using RestApiModeloDDD.Domain.Core.Interface.Repository;
using RestApiModeloDDD.Domain.Core.Interface.Services;
using RestApiModeloDDD.Domain.Service;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interface;
using RestApiModeloDDD.Infrastructure.CrossCutting.Mapper;
using RestApiModeloDDD.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            //injeção de dependencias

            #region IOC

            builder.RegisterType<AplicatonServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<AplicatonServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion
        }
    }
}
