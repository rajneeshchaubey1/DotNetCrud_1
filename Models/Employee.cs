using System.ComponentModel.DataAnnotations;

namespace DotNetCrud.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int Salary { get; set; }
        public Department DepartmentId { get; set; }
    }
}