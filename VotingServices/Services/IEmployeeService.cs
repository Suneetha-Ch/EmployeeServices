using EmployeeServices.Models;
using EmployeeServices.Models.DepartmentDetails;
using EmployeeServices.Models.Dtos;
using EmployeeServices.Models.HumanResources;

namespace EmployeeServices.Services
{
    public interface IEmployeeService
    {
        public Task<ServiceResponse<List<EmployeeResponseDTO>>> GetAlEmployees();
        public Task<ServiceResponse<EmployeeResponseDTO>> GetEmployeeById(string id);
        public Task<ServiceResponse<EmployeeResponseDTO>> AddEmployee(AddEmployeeRequestDTO employee);
        public  Task<ServiceResponse<EmployeeResponseDTO>> UpdateEmployee(UpdateEmploeeRequestDTO updatedEmployee);
        public Task<ServiceResponse<EmployeeResponseDTO>> DeleteEmployee(string id);
        
    }
}
