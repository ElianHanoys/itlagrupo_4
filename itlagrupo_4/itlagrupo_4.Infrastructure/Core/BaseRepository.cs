

using itlagrupo_4.Domain.Repository;
using itlagrupo_4.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace itlagrupo_4.Infrastructure.Core
{
    public abstract class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly PubsContext context;
        private readonly DbSet<TEntity> myDbSet;
        

        public BaseRepository(PubsContext context)
        {
            this.context = context;
            this.myDbSet = this.context.Set<TEntity>();
        }


        public virtual bool Exists(Expression<Func<TEntity, bool>> filter)
        {
            return this.myDbSet.Any(filter);
        }


        public virtual List<TEntity> GetEntities()
        {
            return this.myDbSet.ToList();
        }

        public virtual TEntity GetEntity(int au_id)
        {
            return this.myDbSet.Find(au_id);
        }


        public virtual void Add(TEntity entity)
        {
            this.myDbSet.Add(entity);
        }

        public virtual void Added(TEntity[] entities)
        {
            this.myDbSet.AddRange(entities); 
        }

        public virtual void Remove(TEntity entity)
        {
            this.myDbSet.Remove(entity);

        }
        public virtual void Remove(TEntity[] entities)
        {
            this.myDbSet.RemoveRange(entities);
        }

        public virtual void Update(TEntity entity)
        {
            this.myDbSet.Update(entity);
        }
        public virtual void Update(TEntity[] entities)
        {
            this.myDbSet.UpdateRange(entities);
        }
        public virtual void SaveChanges()
        {
            this.context.SaveChanges();
        }
   
    }
}
