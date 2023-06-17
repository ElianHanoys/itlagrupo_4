using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Entities.Repository;
using itlagrupo_4.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlagrupo_4.Infrastructure.Repositories
{
    public class jobsRepository : BaseRepository <jobs>, IRepositoryBase<jobs>
    {
        public override List<jobs> GetEntities()
        {
            // adaptacion a nuestro requerimiento

            return new List<jobs>();
        }

    }
}