using EmployeeManagementSystem.EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Service.Employees
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployeesAsync();
        Employee GetEmployeeByIdAsync(int id);
    }
}
