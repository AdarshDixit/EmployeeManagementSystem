using EmployeeManagementSystem.EMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Domain.DataTransferObjects
{
    public class EmployeeDto
    { 
        [Required]
        [MaxLength(50)]
        public string FirstName { get; protected set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; protected set; }

        public Department Department { get; set; }
    }
}
