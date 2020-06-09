using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.EMS.Domain.DataTransferObjects;
using EmployeeManagementSystem.EMS.Domain.Entities;
using Mapster;

namespace EmployeeManagementSystem.EMS.Service.Mapping
{
    public class EmployeeMapping : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Employee, GetEmployeeDto>()
                .Map(dest => dest.FullName, src => $"{src.FirstName} {src.LastName}")
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Department, src => src.Department.ToString());
        }
    }
}
