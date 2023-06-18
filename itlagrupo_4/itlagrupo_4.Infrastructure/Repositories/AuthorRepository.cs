
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Repository;
using itlagrupo_4.Infrastructure.Context;
using itlagrupo_4.Infrastructure.Core;
using itlagrupo_4.Infrastructure.Exceptions;
using itlagrupo_4.Infrastructure.Interfaces;
using itlagrupo_4.Infrastructure.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
            if (this.Exists(aut => aut.au_lname == entity.au_lname))
                throw new AuthorException("El author ya existe.");

            base.Add(entity);
            base.SaveChanges();
        }

        public override void Update(Author entity)
        {
            try
            {
                Author authorToUpdate = base.GetEntity(entity.au_id);
                if (authorToUpdate is null)
                
                    throw new AuthorException("El author no existe");
                

                authorToUpdate.au_lname = entity.au_lname;
                authorToUpdate.au_fname = entity.au_fname;
                authorToUpdate.phone = entity.phone;
                authorToUpdate.address = entity.address;
                authorToUpdate.contract = entity.contract;

                base.Update(authorToUpdate);
                base.SaveChanges();

            }
            catch (Exception ex) 
            {
                this.logger.LogError("Ocurrio un error actualizando el autor",ex.ToString());
            }
            
        }

        public override void Remove(Author entity)
        {

            try
            {
                Author authorToRemove = base.GetEntity(entity.au_id);
                if (authorToRemove is null)
           
                    throw new AuthorException("El author no existe");

                authorToRemove.au_lname = entity.au_lname;
                authorToRemove.au_fname =  entity.au_fname;

                base.Update(authorToRemove);
                base.SaveChanges();
                
            }
            catch (Exception ex)
            {

                this.logger.LogError("Ocurrio un error actualizando el autor",ex.ToString());

            }
        }

        public List<AuthorModel> GetAuthor()
        {

            List<AuthorModel> authors = new List<AuthorModel>();
            try
            {
                authors = (from aut in base.GetEntities()
                           select new AuthorModel()
                           {
                               au_id = aut.au_id,
                               au_lname = aut.au_lname,
                               address = aut.address

                           }).ToList();

                           
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error obeteniendo los authores: {ex.Message}", ex.ToString());
            }

            return authors;
        }

    }
}
