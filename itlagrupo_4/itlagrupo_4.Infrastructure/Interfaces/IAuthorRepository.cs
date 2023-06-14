

using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Repository;
using System.Collections.Generic;

namespace itlagrupo_4.Infrastructure.Interfaces
{
    public interface IAuthorRepository : IRepositoryBase<Author>
    {
        List<Author> GetAuthorByTitleAuthor(int  titleId);
    }
}
