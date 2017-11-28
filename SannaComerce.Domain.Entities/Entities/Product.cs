namespace SannaComerce.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// abstraction of products.
    /// </summary>
    public class Product: SannaComerce
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }
        
    }

}
