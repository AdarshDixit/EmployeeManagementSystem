using EmployeeManagementSystem.EMS.Domain.Entities;
using EmployeeManagementSystem.EMS.Domain.QueryStringParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Service.Employees
{
    public interface IService<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllEmployeesAsync(IQueryParam param);
        Task<T> GetEmployeeByIdAsync(int id);
    }
}
