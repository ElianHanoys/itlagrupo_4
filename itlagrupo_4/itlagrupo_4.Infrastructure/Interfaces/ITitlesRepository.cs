using System;
using System.Collections.Generic;
using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Repository;

namespace itlagrupo_4.Infrastructure.Interfaces
{
	public interface ITitlesRepository : IRepositoryBase<Titles>
	{
		List<Titles> GetTitlesById(int titlesID);

	}
}

