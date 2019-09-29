using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByKey(params int[] keys);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
