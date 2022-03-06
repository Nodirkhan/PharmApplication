using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharm.Application.DTOs.Employees;
using Pharm.Application.Interface;
using System.Threading.Tasks;

namespace Phamr.CRUDAPI.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServiceAsync _employeeService;

        public EmployeeController(IEmployeeServiceAsync employee)
        {
            _employeeService = employee;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _employeeService.GetAllEmployeeAsync());
        } 
        [HttpGet("id:int")]
        public async Task<IActionResult> GetAsync(int id)
        {
            return Ok(await _employeeService.GetEmployeeAsync(id));
        }
        [HttpPost("id:int/employee")]
        public async Task<IActionResult> GetPostAsync(EmployeeForCreationDTO employee)
        {
            return Created(" ", await _employeeService.CreateEmployeeAsync(employee));
        }
        [HttpDelete("id:int/employee")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _employeeService.DeleteEmployeeAsync(id);
            return StatusCode(200);
        }
    }
}
