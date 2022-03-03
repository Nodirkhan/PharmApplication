
using System.Collections.Generic;

namespace Pharm.Domain.Models
{
    public class Supplier: BaseEntity
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

        public IList<Product> Products { get; set; }
    }
}
