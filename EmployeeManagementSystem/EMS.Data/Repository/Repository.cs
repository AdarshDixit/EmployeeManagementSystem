using EmployeeManagementSystem.EMS.Domain.Entities;
using EmployeeManagementSystem.EMS.Domain.Pagination;
using EmployeeManagementSystem.EMS.Domain.QueryStringParameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
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


        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public virtual async Task<ICollection<T>> GetAllAsyn(IQueryParam param)
        {

            return await PaginatedList<T>.CreateAsync(context.Set<T>(), param.PageNumber, param.PageSize);
        }

        public virtual T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public virtual async Task<T> GetAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public virtual T Add(T t)
        {

            context.Set<T>().Add(t);
            context.SaveChanges();
            return t;
        }

        public virtual async Task<T> AddAsyn(T t)
        {
            context.Set<T>().Add(t);
            await context.SaveChangesAsync();
            return t;

        }

        public virtual T Find(Expression<Func<T, bool>> match)
        {
            return context.Set<T>().SingleOrDefault(match);
        }

        public virtual async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await context.Set<T>().SingleOrDefaultAsync(match);
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            return context.Set<T>().Where(match).ToList();
        }

        public async Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await context.Set<T>().Where(match).ToListAsync();
        }

        public virtual void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public virtual async Task<int> DeleteAsyn(T entity)
        {
            context.Set<T>().Remove(entity);
            return await context.SaveChangesAsync();
        }

        public virtual T Update(T t, object key)
        {
            if (t == null)
                return null;
            T exist = context.Set<T>().Find(key);
            if (exist != null)
            {
                context.Entry(exist).CurrentValues.SetValues(t);
                context.SaveChanges();
            }
            return exist;
        }

        public virtual async Task<T> UpdateAsyn(T t, object key)
        {
            if (t == null)
                return null;
            T exist = await context.Set<T>().FindAsync(key);
            if (exist != null)
            {
                context.Entry(exist).CurrentValues.SetValues(t);
                await context.SaveChangesAsync();
            }
            return exist;
        }

        public int Count()
        {
            return context.Set<T>().Count();
        }

        public async Task<int> CountAsync()
        {
            return await context.Set<T>().CountAsync();
        }

        public virtual void Save()
        {

            context.SaveChanges();
        }

        public async virtual Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = context.Set<T>().Where(predicate);
            return query;
        }

        public virtual async Task<ICollection<T>> FindByAsyn(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().Where(predicate).ToListAsync();
        }

        public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {

            IQueryable<T> queryable = GetAll();
            foreach (Expression<Func<T, object>> includeProperty in includeProperties)
            {

                queryable = queryable.Include<T, object>(includeProperty);
            }

            return queryable;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
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
