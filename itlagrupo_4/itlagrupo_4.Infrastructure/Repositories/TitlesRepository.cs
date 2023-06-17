using System;
using System.Collections.Generic;
using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Repository;

namespace itlagrupo_4.Infrastructure.Repositories
{
	public class TitlesRepository: IRepositoryBase<Titles>
	{
        public List<Titles> GetEntities()

        {   // adaptacion a nuestro requerimiento
            List<Titles> titles = new List<Titles>();
            return new List<Titles>();
        }

        public Titles GetEntityById(int Id)

        {   // adaptacion a nuestro requerimiento
            Titles title = null;
            return title;
        }

        public void save(Titles entity)
        {
            // Adaptacion a nuestro requerimiento
        }

        public void update(Titles entity)
        {
            // Adaptacion a nuestro requerimiento
        }
    }

}

