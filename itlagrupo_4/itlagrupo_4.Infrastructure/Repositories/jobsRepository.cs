using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Entities.Repository;
using itlagrupo_4.Infrastructure.Core;
using itlagrupo_4.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlagrupo_4.Infrastructure.Repositories
{
    public class jobsRepository : BaseRepository<jobs>, IjobsRepository
    {
      public List<jobs> GetJobsBypublishers(int pub_id)
        {
            throw new System.NotImplementedException();
        }

    }
}