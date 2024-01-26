using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Core.Interface.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void add(TEntity obj);

        void update(TEntity obj);

        void Remove(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}
