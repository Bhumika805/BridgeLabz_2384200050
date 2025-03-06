using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interface;
using RepositoryLayer.Entity;
using System.Collections.Generic;
using NLog;
using Microsoft.Extensions.Logging;

namespace ReviewProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReviewProjectController : ControllerBase
    {
        private readonly IEmployeeBL _employeeBL;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public ReviewProjectController(IEmployeeBL employeeBL)
        {
            _employeeBL = employeeBL;
            
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee(EmployeeEntity employee)
        {
            var addedEmployee = _employeeBL.AddEmployee(employee);
            return Created("Employee Created", addedEmployee);
        }

        [HttpGet("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeBL.GetAllEmployees();
            return Ok(employees);
        }

        [HttpGet("GetEmployee/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeBL.GetEmployeeById(id);
            if (employee == null)
                return NotFound(new { Message = "Employee not found" });

            return Ok(employee);
        }

        [HttpPut("UpdateEmployee/{id}")]
        public IActionResult UpdateEmployee(int id, EmployeeEntity employee)
        {
            var updatedEmployee = _employeeBL.UpdateEmployee(id, employee);
            if (updatedEmployee == null)
                return NotFound(new { Message = "Employee not found" });

            return Ok(updatedEmployee);
        }

        [HttpDelete("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            bool isDeleted = _employeeBL.DeleteEmployee(id);
            if (!isDeleted)
                return NotFound(new { Message = "Employee not found" });

            return Ok(new { Message = "Employee deleted successfully" });
        }

        [HttpGet("employees")]
        public IActionResult GetEmployees()
        {
            logger.Info("Fetching Employee List...");  //  Now logger exists
            var employees = _employeeBL.GetAllEmployees();
            return Ok(new { success = true, message = "Employees retrieved", data = employees });
        }
    }
}
