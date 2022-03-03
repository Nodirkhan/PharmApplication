using System;
using System.Collections.Generic;

namespace Pharm.Domain.Models
{
    public class OrderDatail : AuditbleBaseEntity 
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public IList<Product> Products { get; set; }
    }
}
