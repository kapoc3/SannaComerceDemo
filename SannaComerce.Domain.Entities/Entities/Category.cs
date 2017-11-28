using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SannaComerce.Domain.Entities.Entities
{
    /// <summary>
    /// abstraction of categories.
    /// </summary>
    public class Category:SannaComerce
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
