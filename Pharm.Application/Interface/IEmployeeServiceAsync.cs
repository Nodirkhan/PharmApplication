using Pharm.Application.DTOs.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Application.Interface
{
    public interface IEmployeeServiceAsync
    {
        Task<EmployeeDTO> CreateEmployeeAsync(EmployeeForCreationDTO employeeDTO);

        Task<IReadOnlyList<EmployeeDTO>> GetAllEmployeeAsync();
        
        Task<EmployeeDTO> GetEmployeeAsync(int Id);

        Task DeleteEmployeeAsync (int Id);
    }
}
