using EmployeeServices.Models;
using EmployeeServices.Models.DepartmentDetails;

namespace EmployeeServices.Services
{
    public interface IDepartmentService
    {
        public Task<ServiceResponse<List<Department>>> GetAllDepartments();
        public Task<ServiceResponse<Department>> GetDepartmentById(int id);
    }
}
