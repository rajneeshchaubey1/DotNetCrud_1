using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCrud.Models
{
    public interface IEmployeeRespository
    {
        Task<IEnumerable<Employee>> getAllEmployees();
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> updateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int id);
        Task<Employee> FindEmployee(int id);
    }
}