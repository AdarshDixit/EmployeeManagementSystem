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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FirstName = "Bruce", LastName = "Lee", Department = Domain.Enums.Department.Marketing },
                new Employee { Id = 2, FirstName = "Albert", LastName = "Einstein", Department = Domain.Enums.Department.Operations },
                new Employee { Id = 3, FirstName = "Mark", LastName = "Zuck", Department = Domain.Enums.Department.HR },
                new Employee { Id = 4, FirstName = "Dwayne", LastName = "Jhonson", Department = Domain.Enums.Department.Marketing },
                new Employee { Id = 5, FirstName = "Elon", LastName = "Musk", Department = Domain.Enums.Department.Operations },
                new Employee { Id = 6, FirstName = "Jackie", LastName = "Chan", Department = Domain.Enums.Department.Marketing },
                new Employee { Id = 7, FirstName = "Holy", LastName = "Crap", Department = Domain.Enums.Department.Marketing },
                new Employee { Id = 8, FirstName = "Donald", LastName = "Trump", Department = Domain.Enums.Department.HR },
                new Employee { Id = 9, FirstName = "Crazy", LastName = "Head", Department = Domain.Enums.Department.Marketing },
                new Employee { Id = 10, FirstName = "Lazy", LastName = "Pant", Department = Domain.Enums.Department.Marketing },
                new Employee { Id = 11, FirstName = "FName", LastName = "LName", Department = Domain.Enums.Department.Marketing },
                new Employee { Id = 12, FirstName = "Billi", LastName = "Mandy", Department = Domain.Enums.Department.Marketing },
                new Employee { Id = 13, FirstName = "Jeff", LastName = "Bezos", Department = Domain.Enums.Department.Marketing }
                );
        
        }
    }
}
