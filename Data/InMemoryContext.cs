using System.Collections.Generic;
using DotNetCrud.Models;

namespace DotNetCrud.Data
{
    public class InMemoryContext
    {
        public IList<Employee> Employees { get; set; }
        public IList<Department> Departments { get; set; }


        public InMemoryContext()
        {
            Departments = new List<Department>()
            {
                new Department{DepartmentName="IT", Id=11},
                new Department{DepartmentName="IT", Id=12},
            };
            Employees = new List<Employee>()
            {
                new Employee{Id=1, Name="Jayant", Salary=10000, DepartmentId=Departments[0]},
                new Employee{Id=2, Name="Alba", Salary=25000, DepartmentId=Departments[1]},
            };
        }
    }
}