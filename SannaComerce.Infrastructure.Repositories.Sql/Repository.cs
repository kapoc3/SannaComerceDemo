namespace SannaComerce.Infrastructure.Repositories.Sql
{
    using Context;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Pettern repository for SqlServer
    /// </summary>
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SannaComerceContext _context = new SannaComerceContext();

        /// <summary>
        /// Create new object instance in database.
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        /// <summary>
        /// Delete a object instance for database
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        /// <summary>
        /// get a object inbstance by Id
        /// </summary>
        /// <param name="id">Unique identifier of instance</param>
        /// <returns>Object instance of generic type.</returns>
        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        /// <summary>
        /// search all instances for generic type.
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        /// <summary>
        /// Update object instance in sql persistence
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
