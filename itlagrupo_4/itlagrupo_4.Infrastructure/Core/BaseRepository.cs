﻿

using itlagrupo_4.Domain.Repository;
using System.Collections.Generic;

namespace itlagrupo_4.Infrastructure.Core
{
    public abstract class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        public virtual List<TEntity> GetEntities()
        {
            throw new System.NotImplementedException();
        }

        public virtual TEntity GetEntityById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Save(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        //public abstract void miMetodo();
    }
}
