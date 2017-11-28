using SannaComerce.CrossCutting.Ioc;
using SannaComerce.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SannaComerce.Services.Logic.Services
{
    /// <summary>
    /// Class Expose Business Operations for product entity Domain
    /// </summary>
    public class Product: ServiceBase
    {
        /// <summary>
        /// Get All products
        /// </summary>
        /// <returns></returns>
        public List<SannaComerce.Domain.Entities.Product> GetAll()
        {
            return ServiceLocator.GetInstance<IRepository<SannaComerce.Domain.Entities.Product>>(ServiceBase.repositorySource).GetAll().ToList(); 
        }

        public void Save(SannaComerce.Domain.Entities.Product instance)
        {
            ServiceLocator.GetInstance<IRepository<SannaComerce.Domain.Entities.Product>>(ServiceBase.repositorySource).Create(instance);
        }
    }
}
