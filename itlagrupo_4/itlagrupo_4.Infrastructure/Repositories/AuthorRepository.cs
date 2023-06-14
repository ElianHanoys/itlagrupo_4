
using System.Collections.Generic;
using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Repository;
using itlagrupo_4.Infrastructure.Core;
using itlagrupo_4.Infrastructure.Interfaces;

namespace itlagrupo_4.Infrastructure.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public List<Author> GetAuthorByTitleAuthor(int titleId)
        {
            throw new System.NotImplementedException();
        }
    }
}
