using MyClinic.Domain.Interfaces.Repositories;
using MyClinic.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly MyClinicContext _myClinicContext;

        public RepositoryBase(MyClinicContext myClinicContext)
        {
            this._myClinicContext = myClinicContext;
        }

        public virtual void Add(TEntity entity)
        {
            this._myClinicContext.Add(entity);
            this._myClinicContext.SaveChanges();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return this._myClinicContext.Set<TEntity>();
        }

        public virtual TEntity GetByKey(params int[] keys)
        {
            return this._myClinicContext.Set<TEntity>().Find(keys);
        } 

        public virtual void Update(TEntity entity)
        {
            this._myClinicContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this._myClinicContext.SaveChanges();
        }

        public virtual void Remove(TEntity entity)
        {
            this._myClinicContext.Remove(entity);
            this._myClinicContext.SaveChanges();
        }
    }
}
