using System;
using AttendanceSystem.Domain.Entities;

namespace AttendanceSystem.Application.Interfaces
{
	public interface IEmployeeService
	{
        void Join(Employee employee);
        Employee GetEmployee(int employeeId);
        IEnumerable<Employee> GetEmployees();
        void Leave(int employeeId);
        void Delete(int employeeId);
    }
}

