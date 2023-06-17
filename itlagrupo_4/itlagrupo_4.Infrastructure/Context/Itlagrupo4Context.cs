using itlagrupo_4.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlagrupo_4.Infrastructure.Context
{
    public partial class Itlagrupo4Context: DbContext
    {
        public Itlagrupo4Context() 
        { 

        }

        public Itlagrupo4Context(DbContextOptions<Itlagrupo4Context> options): base(options)
        {

        }

        public DbSet<jobs> jobs { get; set; }
        public DbSet<publishers> publishers { get; set; }

    }
}
