

using System.Collections.Generic;

namespace itlagrupo_4.Domain.Repository
{
    public interface IRepositoryBase <TEntity> where TEntity : class
    {
        void Add(TEntity entity);   
        void Remove(TEntity entity);
        void SaveChanges();
        void Update(TEntity entity);

        TEntity GetEntity(int au_id);
        List<TEntity> GetEntities();
    }
}
