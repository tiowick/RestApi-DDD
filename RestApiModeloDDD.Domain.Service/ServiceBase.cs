﻿using RestApiModeloDDD.Domain.Core.Interface.Repository;
using RestApiModeloDDD.Domain.Core.Interface.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Service
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {

        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity obj)
        {
            repository.add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            repository.update(obj);
        }
    }
}
