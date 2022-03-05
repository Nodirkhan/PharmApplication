using Microsoft.EntityFrameworkCore;
using Pharm.Domain.Models;
using Pharm.Infrastructure.Context;
using Pharm.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Infrastructure.Repositories
{
    public class EmployeeRepositoryAsync : GenericRepositoriesAsync<Employee>, IEmployeeRepositoryAsync
    {
        private readonly DbSet<Employee> _employee;

        public EmployeeRepositoryAsync(ApplicationDbContext context) : base(context)
        {
            _employee = context.Employees; 
        }
    }
}
