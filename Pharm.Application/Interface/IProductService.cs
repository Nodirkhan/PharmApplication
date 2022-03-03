using Pharm.Application.DTOs;
using Pharm.Application.DTOs.Product;
using Pharm.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Application.Interface
{
    public  interface IProductService
    {
        Task<ProductDTO> CreateProductAsync(ProductForCreationDTO product);

        Task<ProductDTO> GetProductAsync(int Id);

        Task DeleteProductAsync(int Id);

        Task<IReadOnlyList<ProductDTO>> GetAllProductAsync();
    }
}
