using EmployeeManagementSystem.EMS.Data.Repository;
using EmployeeManagementSystem.EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Service.Employees
{
    public class Service<T> : IService<T> where T : BaseEntity
    {
        private readonly IRepository<T> repository;

        public Service(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<T>> GetAllEmployeesAsync()
        {
            return await repository.GetAll();
        }

        public async Task<T> GetEmployeeByIdAsync(int id)
        {
            return await repository.Get(id);
        }
    }
}
