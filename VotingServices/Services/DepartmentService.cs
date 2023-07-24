using EmployeeServices.Models;
using EmployeeServices.Models.DepartmentDetails;

namespace EmployeeServices.Services
{
    public class DepartmentService : IDepartmentService
    {
        public async Task<ServiceResponse<List<Department>>> GetAllDepartments()
        {     
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<Department>> GetDepartmentById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
