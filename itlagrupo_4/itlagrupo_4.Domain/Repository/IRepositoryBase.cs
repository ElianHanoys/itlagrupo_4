using System;
using System.Collections.Generic;

namespace itlagrupo_4.Domain.Repository
{
	public interface IRepositoryBase<TEntity> where TEntity : class 
	{
		void save(TEntity entity);
        void update(TEntity entity);
		TEntity GetEntityById(int Id);
		List<TEntity> GetEntities();
    }
}

