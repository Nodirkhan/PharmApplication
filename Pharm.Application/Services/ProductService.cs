using AutoMapper;
using Pharm.Application.DTOs;
using Pharm.Application.DTOs.Product;
using Pharm.Application.Interface;
using Pharm.Domain.Models;
using Pharm.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository,IMapper mapper)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public async Task<ProductDTO> CreateProductAsync(ProductForCreationDTO productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _productRepository.CreateAsync(product);
            return  _mapper.Map<ProductDTO>(product);
        }

        public async Task DeleteProductAsync(int Id)
        {
            await _productRepository.DeleteAsync(Id);
        }
        public async Task<IReadOnlyList<ProductDTO>> GetAllProductAsync()
        {
           return _mapper.Map<IReadOnlyList<ProductDTO>>(await _productRepository.GetAllAsync());
        }

        public async Task<ProductDTO> GetProductAsync(int Id)
        {
            return  _mapper.Map<ProductDTO>(await _productRepository.GetByIdAsync(product => product.Id == Id, new List<string> { "Categories", "Supplier" }));
        }
    }
}
