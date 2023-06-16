
using System.Collections.Generic;
using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Repository;
using itlagrupo_4.Infrastructure.Context;
using itlagrupo_4.Infrastructure.Core;
using itlagrupo_4.Infrastructure.Exceptions;
using itlagrupo_4.Infrastructure.Interfaces;
using itlagrupo_4.Infrastructure.Models;
using Microsoft.Extensions.Logging;

namespace itlagrupo_4.Infrastructure.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        private readonly ILogger<AuthorRepository> logger;
        private readonly PubsContext context;

        public AuthorRepository(ILogger<AuthorRepository> logger,
                                PubsContext context) : base(context)
        {
            this.logger = logger;
            this.context = context;
        }

        public override void Add(Author entity)
        {
            if (this.Exists(cd => cd.au_id == entity.au_id))
                throw new AuthorException("El author ya existe.");

            base.Add(entity);
            base.SaveChanges();
        }

        public List<AuthorModel> GetAuthor(int au_id)
        {
            throw new System.NotImplementedException();
        }

    }
}
