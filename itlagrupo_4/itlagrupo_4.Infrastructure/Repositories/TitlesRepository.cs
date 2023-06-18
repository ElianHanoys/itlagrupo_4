using System;
using System.Collections.Generic;
using System.Linq;
using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Repository;
using itlagrupo_4.Infrastructure.Core;
using itlagrupo_4.Infrastructure.Context;
using itlagrupo_4.Infrastructure.Models;
using Microsoft.Extensions.Logging;

namespace itlagrupo_4.Infrastructure.Repositories
{
    public class TitlesRepository: BaseRepository<Titles>, IRepositoryBase<Titles>
    {

        private readonly ILogger<TitlesRepository> logger;
        private readonly itlagrupo_4Context context;

        public TitlesRepository(ILogger<TitlesRepository> logger, itlagrupo_4Context context) : base(context)
        {
            this.logger = logger;
            this.context = context;
        }

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

        public override void Add(Titles entity)
        {
            // Adaptacion a nuestro requerimiento
            if (this.Exists(cd => cd.titles == entity.titles))
            {
                throw new Exception("El título ya existe");
            }
            base.Add(entity);
            base.SaveChanges();
        }

        public override void Update(Titles entity)
        {
            try
            {
                Titles titleToUpdate = this.GetEntityById(entity.titlesID);

                if (titleToUpdate is null)

                    throw new Exception("El título no existe");

                titleToUpdate.titlesID = entity.titlesID;
                titleToUpdate.titles = entity.titles;
                titleToUpdate.pubID = entity.pubID;
                titleToUpdate.type = entity.type;
                titleToUpdate.price = entity.price;
                titleToUpdate.advance = entity.advance;
                titleToUpdate.royalty = entity.royalty;
                titleToUpdate.ytd_sales = entity.ytd_sales;
                titleToUpdate.pubdate = entity.pubdate;

                base.Update(titleToUpdate);
                base.SaveChanges();
            }
            catch (Exception ex)
            {
                this.logger.LogError("Ocurrió un error actualizando el título", ex.ToString());
            }
            
        }

        public override void Remove(Titles entity)
        {
            try
            {
                Titles titleToRemove = base.GetEntity(entity.titlesID);

                if (titleToRemove is null)
                    throw new Exception("El título no existe.");
                titleToRemove.titles = entity.titles;

                base.Update(titleToRemove);
                base.SaveChanges();
            }
            catch (Exception ex)
            {
                this.logger.LogError("Ocurrió un error actualizando el título", ex.ToString());
            }
        }


        public List<TitlesModel> GetTitles()
        {

            List<TitlesModel> titles = new List<TitlesModel>();
            try
            {
                titles = (from tit in base.GetEntities()
                           select new TitlesModel()
                           {
                               titlesID = tit.titlesID,
                               titles = tit.titles,
                               type = tit.type

                           }).ToList();


            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error obeteniendo los títulos: {ex.Message}", ex.ToString());
            }

            return titles;
        }

        public List<TitlesModel> GetTitlesByID(int titlesID)
        {
            List<TitlesModel> titles = new List<TitlesModel>();

            try
            {

                this.logger.LogInformation($"Pase por aqui: {titlesID}");

                titles = (from tit in base.GetEntities()
                          join de in context.titles.ToList() on tit.titlesID equals de.titlesID
                          where tit.titlesID == titlesID
                           && !tit.Deleted
                          select new TitlesModel()
                          {
                              titlesID = tit.titlesID,
                              titles = tit.titles,
                              type = de.type,
                          }).ToList();

            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error obeteniendo los títulos: {ex.Message}", ex.ToString());
            }

            return titles;
        }

    }

}

