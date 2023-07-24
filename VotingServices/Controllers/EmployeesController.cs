using EmployeeServices.Models;
using EmployeeServices.Models.Data;
using EmployeeServices.Models.Dtos;
using EmployeeServices.Models.HumanResources;
using EmployeeServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeServices.Controllers
{
    //https://localhost:portnumber/api/employees
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeesDbContext _dbContext;
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        public EmployeesController(EmployeesDbContext dbContext, IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _dbContext = dbContext;
            _employeeService = employeeService;
            _departmentService = departmentService;
        }

        // GET : //https://localhost:portnumber/api/employees/get
        [HttpGet("GetAllEmployees")]
        public async Task<ActionResult<ServiceResponse<List<EmployeeResponseDTO>>>> GetEmployees()
        {
          
           var Employees = await _employeeService.GetAlEmployees();
            return Ok(Employees);
        }

        // GET : //https://localhost:portnumber/api/employees/get
        [HttpGet("GetEmployeeById/{id}")]
        public async Task<ActionResult<ServiceResponse<EmployeeResponseDTO>>> GetEmployeeById(string id)
        {

            var Employees = await _employeeService.GetEmployeeById(id);
            return Ok(Employees);
        }


        [HttpPost("AddEmployee/")]
        public async Task<ActionResult<ServiceResponse<EmployeeResponseDTO>>> AddEmployee(AddEmployeeRequestDTO employee)
        {
            var Employee = await _employeeService.AddEmployee(employee);
          
            return new CreatedResult($"/GetEmployeeById/{Employee.Data.ID}", Employee);
        }

        [HttpPut("UpdateEmployee/")]
        public async Task<ActionResult<ServiceResponse<EmployeeResponseDTO>>> UpdateEmployee(UpdateEmploeeRequestDTO updatedEmployee)
        {
            var Employee = await _employeeService.UpdateEmployee(updatedEmployee);
            return Ok(Employee);
        }
        [HttpDelete("deleteEmployee")]
        public  async  Task<ActionResult<ServiceResponse<EmployeeResponseDTO>>> DeleteEmployee(string id)
        {
            var Employee = await _employeeService.DeleteEmployee(id);
            return Ok(Employee);
        }

    }
}
