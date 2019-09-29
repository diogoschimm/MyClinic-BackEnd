using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByKey(params int[] keys);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
