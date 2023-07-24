using EmployeeServices.Models.DepartmentDetails;
using EmployeeServices.Models.HumanResources;
using Microsoft.EntityFrameworkCore;

namespace EmployeeServices.Models.Data
{
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
      //  public DbSet<Address> Addresses { get; set; }
       // public DbSet<Department> Departments { get; set; }
    }
}
