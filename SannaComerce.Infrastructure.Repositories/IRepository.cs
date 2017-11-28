using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SannaComerce.Infrastructure.Repositories
{
    public interface IRepository<T> : IReadable<T, int> where T : class
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
