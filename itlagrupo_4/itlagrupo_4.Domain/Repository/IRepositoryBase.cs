

using System.Collections.Generic;

namespace itlagrupo_4.Infrastructure.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity:class,new()
    {
        void save(TEntity entity);
        void Update(TEntity entity);
        TEntity GetEntity(int id);

        List<TEntity> GetEntities();

    }
}
