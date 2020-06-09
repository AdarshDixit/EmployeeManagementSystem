using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.EMS.Data.Repository;
using EmployeeManagementSystem.EMS.Domain.DataTransferObjects;
using EmployeeManagementSystem.EMS.Domain.Entities;
using EmployeeManagementSystem.EMS.Domain.QueryStringParameters;
using EmployeeManagementSystem.EMS.Service.Generic;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.EMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IService<Employee> service;

        public EmployeesController(IService<Employee> service)
        {
            this.service = service;
        }
        // GET: api/Employees
        [HttpGet(Name ="GetAll")]
        public async Task<ActionResult<IEnumerable<GetEmployeeDto>>> Get([FromQuery] EmployeeQueryParameter parameter)
        {
            var abc = await service.GetAllAsync(parameter);
            var xyz = TypeAdapter.Adapt<List<GetEmployeeDto>>(abc);
            return Ok(xyz);
        }

        // GET: api/Employees/5
        [HttpGet("{id}", Name = "Get")]
        public GetEmployeeDto Get(int id)
        {
            var abc = service.GetAllById(id);
            return TypeAdapter.Adapt<GetEmployeeDto>(abc);
        }

        // POST: api/Employees
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
