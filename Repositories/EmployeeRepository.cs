using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrud.Repositories
{
    public class EmployeeRepository : IEmployeeRespository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            this._context = context;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            await _context.AddAsync(employee);
            await SaveChanges();
            return employee;
        }
        public async Task<Employee> DeleteEmployee(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await SaveChanges();
            return employee;
        }
        public async Task<IEnumerable<Employee>> getAllEmployees()
        {
            return await _context.Employee.ToListAsync();
        }
        public async Task<Employee> updateEmployee(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            await SaveChanges();
            return employee;
        }
        public async Task<Employee> FindEmployee(int id)
        {
            var student = await _context.Employee.FindAsync(id);
            return student;
        }
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}