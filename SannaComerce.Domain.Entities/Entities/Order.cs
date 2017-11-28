using System;
using System.Collections.Generic;

namespace SannaComerce.Domain.Entities.Entities
{
    /// <summary>
    /// abstraction of orders.
    /// </summary>
    public class Order
    {
        public int id { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public List<Product> Products{ get; set; }
}
}
