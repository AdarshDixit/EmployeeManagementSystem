using Microsoft.AspNetCore.Razor.Language.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EMS.Domain.QueryStringParameters
{
    public interface IQueryParam
    {
        int PageNumber { get; set; }
        int PageSize { get; set; }
    }
}
