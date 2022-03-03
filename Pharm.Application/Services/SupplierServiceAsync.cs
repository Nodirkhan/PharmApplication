using AutoMapper;
using Pharm.Application.DTOs.Suppliers;
using Pharm.Application.Interface;
using Pharm.Domain.Models;
using Pharm.Infrastructure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pharm.Application.Services
{
    public class SupplierServiceAsync : ISupplierServiceAsync
    {
        private readonly IMapper _mapper;
        private readonly ISupplierRepositoryAsync _supplierRepository;

        public SupplierServiceAsync(ISupplierRepositoryAsync repository, IMapper mapper)
        {
            _mapper = mapper;
            _supplierRepository = repository;
        }

        public async Task<SupplierDTO> CreateSupplierAsync(SupplierForCreationDTO supplier)
        {
            var suppilerItem = _mapper.Map<Supplier>(supplier);
            await _supplierRepository.CreateAsync(suppilerItem);
            return _mapper.Map<SupplierDTO>(suppilerItem);
        }

        public async Task DeleteSupplierAsync(int Id)
        {
            await _supplierRepository.DeleteAsync(Id);
        }

        public async Task<IReadOnlyList<SupplierDTO>> GetAllSupplierAsync()
        {
            return _mapper.Map<IReadOnlyList<SupplierDTO>>(await _supplierRepository.GetAllAsync());
        }

        public async Task<SupplierDTO> GetSupplierAsync(int Id)
        {
            return _mapper.Map<SupplierDTO>(await _supplierRepository.GetByIdAsync(supplier => supplier.Id == Id, new List<string>()));
        }
    }
}
