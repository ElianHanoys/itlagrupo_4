using itlagrupo_4.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlagrupo_4.Infrastructure.context
{
    public partial class EmployeeContext:DbContext
    {
        public EmployeeContext() 
        {

        }
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) 
        {

        }

        public DbSet<EmployeeRepository> Employees { get; set; }
        
    }
}
