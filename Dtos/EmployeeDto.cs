using DotNetCrud.Models;

namespace DotNetCrud_1.Dtos
{
    public class EmployeeDto
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Department DepartmentId { get; set; }
    }
}