using EmployeeManagementSystem.EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Data.Repository
{
    public class EmployeeRepository : SQLRepository<Employee, EmployeeDataContext>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDataContext context) : base(context)
        {

        }
    }
}
