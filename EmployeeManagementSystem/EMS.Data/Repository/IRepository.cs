using Dapper;
using EmployeeManagementSystem.EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Data.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
