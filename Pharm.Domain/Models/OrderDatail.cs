using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharm.Domain.Models
{
    public class OrderDatail : AuditbleBaseEntity 
    {

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public IList<Product> Products { get; set; }
    }
}
