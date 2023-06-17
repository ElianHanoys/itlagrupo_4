using System;
using System.Collections.Generic;


namespace itlagrupo_4.Domain.Repository
{
	public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity GetEntity(int titlesID);
        List<TEntity> GetEntities();

        void save(TEntity entity);
        void Save(TEntity[] entities);
        void update(TEntity entity);
        void Remove(TEntity entity);
        TEntity GetEntityById(int Id);

    }
}

