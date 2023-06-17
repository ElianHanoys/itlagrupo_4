using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlagrupo_4.Infrastructure.Interfaces
{
    public interface IjobsRepository : IRepositoryBase<jobs>
    {
        List<jobs> GetJobsBypublishers(int pub_id);
    }
}
