

using Pharm.Domain.Models;

namespace Pharm.Application.DTOs
{
    public class ProductForCreationDTO
    {
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public int CategoriesId { get; set; }

        public int SupplierId { get; set; }

    }
}
