using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.EMS.Data.Repository;
using EmployeeManagementSystem.EMS.Domain.DataTransferObjects;
using EmployeeManagementSystem.EMS.Domain.Entities;
using EmployeeManagementSystem.EMS.Service.Employees;
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
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> Get()
        {
            var abc = await service.GetAllEmployeesAsync();
            return Ok(new List<EmployeeDto>());
        }

        // GET: api/Employees/5
        [HttpGet("{id}", Name = "Get")]
        public EmployeeDto Get(int id)
        {
            var abc = service.GetEmployeeByIdAsync(id);
            return new EmployeeDto();
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
