using System.Collections.Generic;

namespace itlagrupo_4.Infrastructure.Core
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetEntities();
        TEntity GetEntity(int id);
        void save(TEntity entity);
        void Update(TEntity entity);
    }
}