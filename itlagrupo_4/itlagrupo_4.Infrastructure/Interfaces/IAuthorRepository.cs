

using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Repository;
using itlagrupo_4.Infrastructure.Models;
using System.Collections.Generic;

namespace itlagrupo_4.Infrastructure.Interfaces
{
    public interface IAuthorRepository : IRepositoryBase<Author>
    {
        List<AuthorModel> GetAuthor(int  au_id);
    }
}
