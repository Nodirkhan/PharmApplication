using AutoMapper;
using Pharm.Application.DTOs.Employees;
using Pharm.Application.Interface;
using Pharm.Domain.Models;
using Pharm.Infrastructure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pharm.Application.Services
{
    public class EmployeeServiceAsync : IEmployeeServiceAsync
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepositoryAsync _employeeRepository;

        public EmployeeServiceAsync(IEmployeeRepositoryAsync employee,IMapper mapper)
        {
            _mapper = mapper;
            _employeeRepository = employee;
        }
        public async Task<EmployeeDTO> CreateEmployeeAsync(EmployeeForCreationDTO employeeDTO)
        {
            return _mapper.Map<EmployeeDTO>(await _employeeRepository.CreateAsync(_mapper.Map<Employee>(employeeDTO)));
        }

        public async Task DeleteEmployeeAsync(int Id)
        {
            await _employeeRepository.DeleteAsync(Id);
        }

        public async Task<IReadOnlyList<EmployeeDTO>> GetAllEmployeeAsync()
        {
            return _mapper.Map<IReadOnlyList<EmployeeDTO>>(await _employeeRepository.GetAllAsync());
        }

        public async Task<EmployeeDTO> GetEmployeeAsync(int Id)
        {
            return _mapper.Map<EmployeeDTO>(await _employeeRepository.GetByIdAsync(employee => employee.Id == Id, new List<string>()));
        }
    }
}
