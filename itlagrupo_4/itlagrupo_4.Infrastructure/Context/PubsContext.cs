using itlagrupo_4.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace itlagrupo_4.Infrastructure.Context
{
    public partial class PubsContext : DbContext
    {
        public PubsContext()
        {
            
        }
        public PubsContext (DbContextOptions<PubsContext> options) : base(options)
        {
        
        }
        public DbSet<Author> authors { get; set; }
        
    }
}
