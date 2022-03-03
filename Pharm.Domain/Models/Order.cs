using System;

namespace Pharm.Domain.Models
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }


        public int OrderDetailId { get; set; }
        public OrderDatail OrderDetails { get; set; }

        public Employee Employees { get; set; }
    }
}
