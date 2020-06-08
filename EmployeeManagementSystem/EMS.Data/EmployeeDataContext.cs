using EmployeeManagementSystem.EMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Data
{
    public class EmployeeDataContext : DbContext
    {
        public EmployeeDataContext(DbContextOptions opt) : base(opt)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
