using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SannaComerce.CrossCutting.Utilites.Helpers
{
    public static class MemoryHelper
    {
        private static List<object> products;

        /// <summary>
        /// Products memory container.
        /// </summary>
        public static List<object> Products
        {
            get
            {
                if (products == null)
                {
                    products = new List<object>();
                }

                return products;
            }
            set
            {
                products = value;
            }
        }

        public static void Add(object Instance, string name)
        {
            switch (name)
            {
                case "Product":
                    Products.Add(Instance);
                    break;
            }
        }

        /// <summary>
        /// Return all instances of type saved in memory repository.
        /// </summary>
        /// <param name="name">Class Name for repository</param>
        /// <returns>Saved instances</returns>
        public static List<object> GetAll(string name)
        {
            List<object> kapoc = new List<object>();

            switch (name)
            {
                case "Product":
                    kapoc = MemoryHelper.Products;
                    break;
            }

            return kapoc;
        }
    }
}
