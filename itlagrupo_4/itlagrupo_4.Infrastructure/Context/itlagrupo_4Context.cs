
using System;
using itlagrupo_4.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace itlagrupo_4.Infrastructure.Context
{
    public partial class itlagrupo_4Context : DbContext {

        public itlagrupo_4Context()
        {

        }
        public itlagrupo_4Context(DbContextOptions<itlagrupo_4Context> options) : base(options)
        {

        }
        public DbSet<Titles> titles {get;set;}

    }
}

