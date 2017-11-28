using SannaComerce.CrossCutting.Utilites.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SannaComerce.Infrastructure.Repositories.Memory
{
    /// <summary>
    /// Memory implementation for Repository contract
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        
        /// <summary>
        /// Create new object instance in database.
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            MemoryHelper.Add(entity,typeof(T).Name);
        }

        /// <summary>
        /// Delete a object instance for database
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// get a object inbstance by Id
        /// </summary>
        /// <param name="id">Unique identifier of instance</param>
        /// <returns>Object instance of generic type.</returns>
        public async Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// search all instances for generic type.
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return MemoryHelper.GetAll(typeof(T).Name).Cast<T>().AsQueryable();
        }

        /// <summary>
        /// Update object instance in sql persistence
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
