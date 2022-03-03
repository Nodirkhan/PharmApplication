
using Pharm.Application.DTOs.Suppliers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pharm.Application.Interface
{
    public  interface ISupplierServiceAsync
    {
        Task<SupplierDTO> CreateSupplierAsync(SupplierForCreationDTO supplier);

        Task DeleteSupplierAsync(int Id);

        Task<IReadOnlyList<SupplierDTO>> GetAllSupplierAsync();

        Task<SupplierDTO> GetSupplierAsync(int Id);


    }
}
