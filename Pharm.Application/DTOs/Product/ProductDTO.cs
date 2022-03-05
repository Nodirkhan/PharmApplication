using Pharm.Application.DTOs.Categories;
using Pharm.Application.DTOs.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Application.DTOs.Product
{
    public class ProductDTO : ProductForCreationDTO 
    {
        public int Id { get; set; } 

     /*   public CategoryDTO Categories { get; set; }

        public SupplierDTO Supplier { get; set; }*/
    }
}
