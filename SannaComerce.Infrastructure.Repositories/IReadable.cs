using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SannaComerce.Infrastructure.Repositories
{
    public interface IReadable<TEntity, in TKey> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> Get(TKey id);
    }
}
