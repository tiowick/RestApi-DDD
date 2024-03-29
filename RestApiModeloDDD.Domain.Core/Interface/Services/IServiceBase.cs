﻿using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Core.Interface.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
         void Add (TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}
