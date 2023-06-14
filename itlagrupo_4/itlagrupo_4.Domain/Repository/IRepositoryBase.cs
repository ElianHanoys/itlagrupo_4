

using System.Collections.Generic;

namespace itlagrupo_4.Domain.Repository
{
    public interface IRepositoryBase <TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        void Update(TEntity entity);

        TEntity GetEntityById(int Id);
        List<TEntity> GetEntities();
    }
}
