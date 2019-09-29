using MyClinic.Application.Interfaces;
using MyClinic.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Application.Services
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            this._serviceBase = serviceBase;
        }

        public void Add(TEntity entity)
        {
            this._serviceBase.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this._serviceBase.GetAll();
        }

        public TEntity GetByKey(params int[] keys)
        {
            return this._serviceBase.GetByKey(keys);
        }

        public void Remove(TEntity entity)
        {
            this._serviceBase.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            this._serviceBase.Update(entity);
        }
    }
}
