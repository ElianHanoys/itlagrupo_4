using System;
using System.Collections.Generic;
using System.Text;

namespace itlagrupo_4.Domain.Entities.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Save(TEntity entity);

        void Update(TEntity entity);

        TEntity GetEntityById(int id);

        List<TEntity> GetEntities();
    }
}
