using MyClinic.Domain.Interfaces.Repositories;
using MyClinic.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            this._repositoryBase = repositoryBase;
        }

        public void Add(TEntity entity)
        {
            this._repositoryBase.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this._repositoryBase.GetAll();
        }

        public TEntity GetByKey(params int[] keys)
        {
            return this._repositoryBase.GetByKey(keys);
        }

        public void Remove(TEntity entity)
        {
            this._repositoryBase.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            this._repositoryBase.Update(entity);
        }
    }
}
