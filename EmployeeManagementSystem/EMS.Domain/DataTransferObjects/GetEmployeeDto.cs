using EmployeeManagementSystem.EMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Domain.DataTransferObjects
{
    public class GetEmployeeDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string Department { get; set; }
    }
}
