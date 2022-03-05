using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Application.DTOs.Orders
{
    public class OrderForCreationDTO
    {
        public DateTime OrderDate { get; set; }


        public int OrderDetailId { get; set; }

        public int EmployeeId { get; set; }
    }
}
