using EmployeeManagementSystem.EMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Domain.Entities
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; protected set; }
        
        [Required]
        [MaxLength(50)]
        public string LastName { get; protected set; }

        public Department Department { get; set; }
        
    }
}
