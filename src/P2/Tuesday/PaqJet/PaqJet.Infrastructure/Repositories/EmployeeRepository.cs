using Microsoft.EntityFrameworkCore;
using PaqJet.Domain.Entities;
using PaqJet.Infrastructure.Interfaces;
using PaqJet.Infrastructure.Models;
using PaqJet.Persistence;

namespace EmployeeJet.Infrastructure.Interfaces
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public int Counter;

        private readonly PaqJetDbContext _context;

        public EmployeeRepository(PaqJetDbContext context)
        {
            _context = context;
            Counter++;
        }

        public async Task<List<EmployeeModel>> Get()
        {
            var employees = new List<EmployeeModel>();
            var employeesDb = await _context.Employees.ToListAsync();
            if (!employeesDb.Any())
            {
                throw new Exception("Employees not found");
            }
            foreach (var employee in employeesDb)
            {
                employees.Add(new EmployeeModel
                {
                    Salary = employee.Salary,
                    Name = employee.Name,
                    LastName = employee.LastName,
                });
            }

            return employees;

        }

        public async Task<EmployeeModel> GetById(int id)
        {
            var employeeModel = new EmployeeModel();
            var employeeDb = await _context.Employees.FindAsync(id);
            if (employeeDb == null)
            {
                throw new Exception("Employee not found");
            }

            employeeModel.Name = employeeDb.Name;
            employeeModel.LastName = employeeDb.LastName;
            employeeModel.Salary = employeeDb.Salary;
            return employeeModel;

        }

        public async Task<EmployeeModel> Add(EmployeeModel request)
        {
            var dbEmployee = new Employee();

            dbEmployee.Name = request.Name;
            dbEmployee.LastName = request.LastName;
            dbEmployee.Salary = request.Salary;

            _context.Employees.Add(dbEmployee);
            return new EmployeeModel { Id = dbEmployee.Id };

        }


        public async Task<bool> Update(EmployeeModel request)
        {
            var dbEmployee = await _context.Employees.FindAsync(request.Id);
            if (dbEmployee == null)
            {
                throw new Exception("Employee not found"); ;
            }

            dbEmployee.Name = request.Name;
            dbEmployee.LastName = request.LastName;
            dbEmployee.Salary = request.Salary;

            _context.Employees.Update(dbEmployee);
            return true;

        }




    }
}
