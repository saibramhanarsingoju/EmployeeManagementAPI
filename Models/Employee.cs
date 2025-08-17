namespace EmployeeManagementAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Default value added to avoid null
        public string Department { get; set; } = string.Empty; // Default value added to avoid null
        public decimal Salary { get; set; }
    }
}
