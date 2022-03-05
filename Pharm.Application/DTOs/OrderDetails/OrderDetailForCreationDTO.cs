using Pharm.Application.DTOs.Product;
using System.Collections.Generic;

namespace Pharm.Application.DTOs.OrderDetails
{
    public class OrderDetailForCreationDTO
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public IList<ProductDTO> Products { get; set; }
    }
}
