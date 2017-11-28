using SannaComerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SannaComerce.Infrastructure.Repositories.Sql.Context
{
    /// <summary>
    /// Context of Database
    /// </summary>
    public class SannaComerceContext: System.Data.Entity.DbContext
    {
        public SannaComerceContext() : base("name=SannaComerceDbContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Product> Products { get; set; }
        
    }
}
