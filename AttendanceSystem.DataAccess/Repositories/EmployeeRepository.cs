using System;
using AttendanceSystem.DataAccess.Classes;
using AttendanceSystem.DataAccess.Interfaces;
using AttendanceSystem.Domain.Entities;

namespace AttendanceSystem.DataAccess.Repositories
{
	public class EmployeeRepository: IEmployeeRepository
    {
        private readonly AttendanceDbContext _dbContext;

        public EmployeeRepository(AttendanceDbContext dbContext)
		{
            _dbContext = dbContext;
        }

        public void Join(Employee employee) {

            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
        }

        public Employee GetEmployee(int employeeId) {

            return _dbContext.Employees.FirstOrDefault(p => p.Id == employeeId);
        }

        public IEnumerable<Employee> GetEmployees() {
            return _dbContext.Employees.ToList();
        }

        public void Leave(int employeeId) {

            Employee? employee = GetEmployee(employeeId);
            if (employee != null) {
                employee.Status = "left";
                _dbContext.Employees.Update(employee);
                _dbContext.SaveChanges();
            }

        }

        public void Delete(int employeeId) {

            Employee? employee = GetEmployee(employeeId);

            if (employee != null) {
                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
            }
        }
    }
}

