using EmployeeManagementSystem.EMS.Data.Repository;
using EmployeeManagementSystem.EMS.Domain.Entities;
using EmployeeManagementSystem.EMS.Domain.Pagination;
using EmployeeManagementSystem.EMS.Domain.QueryStringParameters;
using EmployeeManagementSystem.EMS.Service.Generic;
using EmployeeManagementSystem.EMS.Service.Predicates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Service
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        private readonly IRepository<T> repository;

        public BaseService(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<T>> GetAllAsync(IQueryParam param)
        {
            return await repository.GetAllAsyn(param);

        }

        public async Task<T> GetAllById(int id)
        {
            return await repository.GetAsync(id);
        }

        public async  Task<IEnumerable<T>> FindAllByDeptType(Expression<Func<T, bool>> exp)
        {
            var predicate = PredicateBuilder.True<T>();
            var xyz = predicate.And(exp);
            return await repository.FindAllAsync(predicate);
        }
    }
}
