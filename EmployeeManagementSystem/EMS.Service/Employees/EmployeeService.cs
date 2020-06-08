using EmployeeManagementSystem.EMS.Data.Repository;
using EmployeeManagementSystem.EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Service.Employees
{
    public class EmployeeService : IEmployeeService
    {

        public EmployeeService()
        {
        }
        public IEnumerable<Employee> GetAllEmployeesAsync()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
