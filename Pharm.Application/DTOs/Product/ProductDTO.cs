using Pharm.Application.DTOs.Categories;
using Pharm.Application.DTOs.Suppliers;
using Pharm.Domain.Models;
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

        public Category Categories { get; set; }

        public Supplier Supplier { get; set; }
    }
}
