using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Domain.Entities
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt => DateTime.Now;
    }
}
