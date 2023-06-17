using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Entities.Repository;
using itlagrupo_4.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlagrupo_4.Infrastructure.Repositories
{
    public class publishersRepository : BaseRepository<publishers>, IRepositoryBase<publishers>
    {
        public override List<publishers> GetEntities()
        {
            // adaptacion a nuestro requerimiento

            return new List<publishers>();
        }
    }
}