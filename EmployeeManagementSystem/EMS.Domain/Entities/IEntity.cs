﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Domain.Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime CreatedAt { get; }
    }
}
