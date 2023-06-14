using itlagrupo_4.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlagrupo_4.Infrastructure.Context
{
    public partial class Itlagrupo_4Context : DbContext
    {
        public Itlagrupo_4Context()
        {
            
        }
        public Itlagrupo_4Context(DbContextOptions<Itlagrupo_4Context> options) : base(options)
        {
        
        }
        public DbSet<Author> authors { get; set; }
        
    }
}
