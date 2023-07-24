namespace EmployeeServices.Models.Dtos
{
    public class UpdateEmploeeRequestDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Departmentname { get; set; }
        public string ReportingMananerName { get; set; }
    }
}
