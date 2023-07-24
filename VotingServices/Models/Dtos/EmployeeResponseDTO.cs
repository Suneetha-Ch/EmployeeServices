namespace EmployeeServices.Models.Dtos
{
    public class EmployeeResponseDTO
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string DepartmentName { get; set; }
        public string ReportingMananerName { get; set; }
    }
}
