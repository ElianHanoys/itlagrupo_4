

using itlagrupo_4.Infrastructure.context;
using itlagrupo_4.Infrastructure.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace itlagrupo_4.Infrastructure.Core
{
    public abstract class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly EmployeeContext _Context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(EmployeeContext context) 
        {
            _Context = context;
            _dbSet=_Context.Set<TEntity>();
        }
        public virtual void ExecutableProcedure(string procedureCommand, params SqlParameter[] sqlparams);
            this._context.Database.ExecuteSqlRaw(procedureCommand, sqlParams);

        
    }
}
