using SannaComerce.Domain.Entities;
using SannaComerce.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SannaComerce.CrossCutting.Ioc
{

    /// <summary>
    /// Patter Ioc.
    /// </summary>
    public class ServiceLocator
    {
        private static Infrastructure.Repositories.IRepository<Product> productRepository;

        /// <summary>
        /// Return the implementer of repository contract.
        /// </summary>
        /// <typeparam name="T">Type of domain entity.</typeparam>
        /// <param name="source">Data source to conect</param>
        /// <returns>Implementator of contract</returns>
        public static T GetInstance<T>(string source)
        {
            T classInstance;
            Type classType = typeof(T);
            
            if (source == "Memory")
            {
                switch (Convert.ToString(classType.GenericTypeArguments.GetValue(0)))
                {
                    case "SannaComerce.Domain.Entities.Product":
                        classInstance = (T)(productRepository = new Infrastructure.Repositories.Memory.Repository<Product>());
                        break;

                    default:
                        throw new Exception(string.Format("{0} It is not an implementer", classType.Name));
                }
            }
            else if (source == "Sql")
            {
                switch (Convert.ToString(classType.GenericTypeArguments.GetValue(0)))
                {
                    case "SannaComerce.Domain.Entities.Product":
                        classInstance = (T)(productRepository = new Infrastructure.Repositories.Sql.Repository<Product>());
                        break;

                    default:
                        throw new Exception(string.Format("{0} It is not an implementer", classType.Name));

                }
            }
            else
            {
                throw new Exception(string.Format("The source: " + source+ " Not found."));
            }

            return classInstance;
        }
        
    }
}
