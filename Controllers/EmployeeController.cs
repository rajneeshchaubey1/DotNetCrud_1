using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCrud.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRespository _employeeRepo;
        public EmployeeController(IEmployeeRespository employeeRepo)
        {
            this._employeeRepo = employeeRepo;
        }

        [HttpGet]
        [Route("employees")]
        public ActionResult<List<Employee>> GetAllEmployees()
        {
            return Ok(_employeeRepo.getAllEmployees());
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> SubmitEmployee([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Bad Request");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newEmployee = await _employeeRepo.AddEmployee(employee);
            return Ok(newEmployee);
        }

        [HttpPut]
        [Route("update/{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Bad Request");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var updatedEmployee = await _employeeRepo.updateEmployee(employee);
            return Ok(updatedEmployee);
        }
    }
}