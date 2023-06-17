using System;
using System.Collections.Generic;
using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace itlagrupo_4.Infrastructure.Core
{
	public abstract class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
	{
		public BaseRepository()
		{
		}

        public List<TEntity> GetEntities()
        {
            // adaptacion a nuestro requerimiento
            List<Titles> titles = new List<Titles>();
            return new List<Titles>();
        }

        public TEntity GetEntityById(int Id)
        {
            // adaptacion a nuestro requerimiento
            Titles title = null;
            return title;
        }

        public void save(TEntity entity)
        {
            // Adaptacion a nuestro requerimiento
        }

        public void update(TEntity entity)
        {
            // Adaptacion a nuestro requerimiento
        }
    }
}

