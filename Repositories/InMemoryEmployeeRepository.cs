using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCrud.Data;
using System.Linq;
using DotNetCrud.Models;

namespace DotNetCrud.Repositories
{
    public class InMemoryEmployeeRepository : IEmployeeRespository
    {
        private readonly InMemoryContext _memoryContext;
        public InMemoryEmployeeRepository(InMemoryContext memoryContext)
        {
            this._memoryContext = memoryContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            _memoryContext.Employees.Add(employee);
            await Task.Delay(100);
            return employee;
        }

        public Task<Employee> DeleteEmployee(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee> FindEmployee(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> getAllEmployees()
        {
            await Task.Delay(0);
            return _memoryContext.Employees.ToList();
        }

        public Task<Employee> updateEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}