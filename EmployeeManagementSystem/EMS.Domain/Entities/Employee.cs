﻿using EmployeeManagementSystem.EMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Domain.Entities
{
    public class Employee : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public Department Department { get; set; }
        
    }
}
