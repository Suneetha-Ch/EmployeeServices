using EmployeeServices.Models.DepartmentDetails;

namespace EmployeeServices.Models.HumanResources
{
    public class Employee
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string DepartmentName { get; set; }
        public string ReportingMananerName { get; set; }

        // Navigation Properties
       // public Department Department { get; set; }

        public Employee()
        {
            
        }
        public Employee(Guid id, string name, string role, string departmentName, string reportingMananerName)
        {
            ID = id;
            Name = name;
            Role = role;
            DepartmentName = departmentName;
            ReportingMananerName = reportingMananerName;

        }
    }
}
