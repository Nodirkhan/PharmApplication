using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharm.Domain.Models
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        
        public int Quantity { get; set; }

        public int CategoriesId { get; set; }
        public Category Categories { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
