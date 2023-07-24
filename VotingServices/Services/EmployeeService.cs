using AutoMapper;
using EmployeeServices.Models;
using EmployeeServices.Models.Data;
using EmployeeServices.Models.Dtos;
using EmployeeServices.Models.HumanResources;
using Microsoft.EntityFrameworkCore;

namespace EmployeeServices.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly  IMapper _mapper;
        private readonly EmployeesDbContext _dbContext;

        public EmployeeService(IMapper mapper, EmployeesDbContext dataContext) 
        {
            _mapper = mapper;
            _dbContext = dataContext;
        }
        public async Task<ServiceResponse<EmployeeResponseDTO>> AddEmployee(AddEmployeeRequestDTO newEmployee)
        {
            var response = new ServiceResponse<EmployeeResponseDTO>();
            try
            {
                // Mapping the AddEmployeeRequestDTO object to Employee class object
                var employee = _mapper.Map<Employee>(newEmployee);
                employee.ID = new Guid();
                 _dbContext.Employees.Add(employee);
                _dbContext.SaveChanges();  
               response.Data = _mapper.Map<EmployeeResponseDTO>(employee);
            }
          catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<EmployeeResponseDTO>> GetEmployeeById(string id)
        {

            var response = new ServiceResponse<EmployeeResponseDTO>();
            try
            {
                var employee = _dbContext.Employees.FirstOrDefault(e => e.ID == new Guid(id));
                response.Data = _mapper.Map<EmployeeResponseDTO>(employee);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response; 
        }

        public async Task<ServiceResponse<List<EmployeeResponseDTO>>> GetAlEmployees()
        {
            var response = new ServiceResponse<List<EmployeeResponseDTO>>();
            try
            {
                var dbEmployees = await _dbContext.Employees.ToListAsync();
                response.Data = dbEmployees.Select(e => _mapper.Map<EmployeeResponseDTO>(e)).ToList();
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
           
            return response;
        }
        public async Task<ServiceResponse<EmployeeResponseDTO>> UpdateEmployee(UpdateEmploeeRequestDTO updatedEmployee)
        {
            var response = new ServiceResponse<EmployeeResponseDTO>();
            try
            {
                // Mapping the AddEmployeeRequestDTO object to Employee class object
                var employee = _mapper.Map<Employee>(updatedEmployee);
                _dbContext.Employees.Update(employee);
                _dbContext.SaveChanges();
                response.Data = _mapper.Map<EmployeeResponseDTO>(employee);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<EmployeeResponseDTO>> DeleteEmployee(string id)
        {
            var response = new ServiceResponse<EmployeeResponseDTO>();
            try
            {
                // Mapping the AddEmployeeRequestDTO object to Employee class object
                var Employee = _dbContext.Employees.FirstOrDefault(emp => emp.ID ==new Guid(id));
                _dbContext.Employees.Remove(Employee);
                _dbContext.SaveChanges();
                response.Data = _mapper.Map<EmployeeResponseDTO>(Employee);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
