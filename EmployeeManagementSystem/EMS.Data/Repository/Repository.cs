using EmployeeManagementSystem.EMS.Domain.Entities;
using EmployeeManagementSystem.EMS.Domain.Pagination;
using EmployeeManagementSystem.EMS.Domain.QueryStringParameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly EmployeeDataContext context;

        public Repository(EmployeeDataContext context)
        {
            this.context = context;
        }
       

        public async Task<T> Add(T entity)
        {
            context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<T> Get(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAll(IQueryParam param)
        {
            // return await context.Set<T>().OrderBy(on => on.Id).ToListAsync();

            return await PaginatedList<T>.CreateAsync(context.Set<T>(), param.PageNumber, param.PageSize);

        }

        public async Task<T> Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }       
    }
}
