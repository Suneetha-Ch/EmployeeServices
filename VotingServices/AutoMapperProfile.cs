using AutoMapper;
using EmployeeServices.Models.Dtos;
using EmployeeServices.Models.HumanResources;

namespace EmployeeServices
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<AddEmployeeRequestDTO, Employee>();
            CreateMap<Employee, EmployeeResponseDTO>();
            CreateMap<UpdateEmploeeRequestDTO, Employee>();
        }
    }
}
